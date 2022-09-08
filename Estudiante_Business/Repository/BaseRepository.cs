using AutoMapper;
using Estudiante_Data.Context;
using Estudiante_Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;


namespace Estudiante_Business.Repository
{
    public class BaseRepository<TModel> : IBaseRepository <TModel> where TModel: class , IBaseEntity, new()
    {
        private readonly DbSet<TModel> _dbSet;
        private readonly BaseContext _context;
        private readonly IMapper _mapper;
        public BaseRepository(BaseContext context,  IMapper mapper)
        {
            _context = context;
            _dbSet = context.Set<TModel>();
            _mapper = mapper;
        }
        public TModel Add(TModel entity)
        {
            return _dbSet.Add(entity).Entity;
        }
        public async Task AddAsync(TModel entity)
           => await _dbSet.AddAsync(entity);
        public IQueryable<TModel> FindBy(Expression<Func<TModel, bool>> predicate)
        {
            IQueryable<TModel> query = _dbSet.Where(predicate);
            return query;
        }
        public TModel Update(TModel entity)
        {
            return _dbSet.Update(entity).Entity;
        }


        public async Task<TModel> FindByAsync(Expression<Func<TModel, bool>> predicate)
        => await _dbSet.FindAsync(predicate);

        public IEnumerable<TModel> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
         => await _dbSet.ToListAsync();

        public TModel GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public async Task<TModel> GetByIdAsync(int id)
          => await _dbSet.FindAsync(id);

        public IQueryable<TModel> GetQueryable(Expression<Func<TModel, bool>> predicate)
          => _dbSet.Where(predicate).AsQueryable();

        public IQueryable<TModel> GetQueryable()
        => _dbSet.AsQueryable();
      
        public void DeleteByEntity(TModel entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);

            return await CommitAsync();
        }
     
        public void RemoveRange(IEnumerable<TModel> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    
        public virtual IEnumerable<Resultado> AddRange(IEnumerable<TModel> entityEnumerable)
        {
           
            _dbSet.AddRange(entityEnumerable);
            yield return new Resultado() { StatusCode = HttpStatusCode.Created, Success = true };
        }
        public virtual async Task<TModel> Find(int id, params Expression<Func<TModel, object>>[] includeProperties)
        {
            IQueryable<TModel> query = _dbSet.AsQueryable();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
        public virtual IQueryable<TModel> FindBy(Expression<Func<TModel, bool>> predicate, params Expression<Func<TModel, object>>[] includeProperties)
        {
            IQueryable<TModel> query = _dbSet.Where(predicate);
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsNoTracking();
        }
        public virtual Resultado Activar(TModel entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            entity.Estatus = true;
            dbEntityEntry.State = EntityState.Modified;
            return new Resultado() { StatusCode = HttpStatusCode.OK, Success = true };
        }
        public virtual async Task<DataCollection<TModel>> GetPagedAsync(
        int page,
        int take,
        Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy,
        Expression<Func<TModel, bool>> predicate = null,
        Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null
    )
        {
            var query = _context.Set<TModel>().AsQueryable();
            var originalPages = page;

            page--;

            if (page > 0)
                page = page * take;

            query = PrepareQuery(query, predicate, include, orderBy);

            var result = new DataCollection<TModel>
            {
                Items = await query.Skip(page).Take(take).ToListAsync(),
                Total = await query.CountAsync(),
                Page = originalPages
            };

            if (result.Total > 0)
            {
                result.Pages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(result.Total) / take));
            }

            return result;
        }
        protected IQueryable<TModel> PrepareQuery(
         IQueryable<TModel> query,
         Expression<Func<TModel, bool>> predicate = null,
         Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null,
         Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null,
         int? take = null
     )
        {
            if (include != null)
                query = include(query);

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = orderBy(query);

            if (take.HasValue)
                query = query.Take(Convert.ToInt32(take));

            return query;
        }
        public virtual TModel FirstOrDefault(
       Expression<Func<TModel, bool>> predicate,
       Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null,
       Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null
   )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return query.FirstOrDefault();
        }

        public virtual async Task<decimal?> SumAsync(
         Expression<Func<TModel, bool>> predicate = null
     )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return await ((IQueryable<decimal?>)query).SumAsync();
        }
        public virtual async Task<int> CountAsync(
         Expression<Func<TModel, bool>> predicate = null
     )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return await query.CountAsync();
        }
        public virtual async Task<TModel> FirstAsync(
      Expression<Func<TModel, bool>> predicate,
      Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null,
      Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null
  )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return await query.FirstAsync();
        }
        public virtual async Task<TModel> SingleAsync(
       Expression<Func<TModel, bool>> predicate,
       Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null
   )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return await query.SingleAsync();
        }
        public virtual async Task<TModel> SingleOrDefaultAsync(
         Expression<Func<TModel, bool>> predicate,
         Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null
     )
        {
            var query = _context.Set<TModel>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return await query.SingleOrDefaultAsync();
        }
        public bool Any(Expression<Func<TModel, bool>> predicate)
        => _dbSet.Any(predicate);
        public bool Commit()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.Write(e);
                throw;
            }
        }

        public async Task<bool> CommitAsync()
        {

            try
            {
                var savedRegistries = await _context.SaveChangesAsync();
                bool succeeded = savedRegistries > 0;
                return succeeded;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }
        public  async Task<Resultado> SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return new Resultado() { Success = true, StatusCode = HttpStatusCode.Created };
            }
            catch (DbUpdateException ex)
            {
                return new Resultado() { Message = ex.Message, StatusCode = HttpStatusCode.InternalServerError };
            }
        }

      
    }
}
