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
    public interface IBaseRepository<TModel> where TModel :class , IBaseEntity, new()
    {
        TModel Add(TModel entity);
        Task AddAsync(TModel entity);
        TModel Update(TModel entity);
        Task<TModel> GetByIdAsync(int id);
        TModel GetById(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
        IEnumerable<TModel> GetAll();
        IQueryable<TModel> FindBy(Expression<Func<TModel, bool>> predicate);
        Task<TModel> FindByAsync(Expression<Func<TModel, bool>> predicate);
        IQueryable<TModel> GetQueryable(Expression<Func<TModel, bool>> predicate);
        IQueryable<TModel> GetQueryable();
        Task<bool> DeleteByIdAsync(int id);
        void DeleteByEntity(TModel entity);
        void RemoveRange(IEnumerable<TModel> entities);
        bool Commit();
        Task<bool> CommitAsync();
        IEnumerable<Resultado> AddRange(IEnumerable<TModel> entityEnumerable);
        Task<TModel> Find(int id, params Expression<Func<TModel, object>>[] includeProperties);
        IQueryable<TModel> FindBy(Expression<Func<TModel, bool>> predicate, params Expression<Func<TModel, object>>[] includeProperties);
        Resultado Activar(TModel entity);
        Task<decimal?> SumAsync(Expression<Func<TModel, bool>> predicate = null);
        Task<int> CountAsync(Expression<Func<TModel, bool>> predicate = null);
        Task<TModel> FirstAsync(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null);
        TModel FirstOrDefault(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null);
        Task<TModel> SingleAsync(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null);
        Task<TModel> SingleOrDefaultAsync(Expression<Func<TModel, bool>> predicate, Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>> include = null);
        bool Any(Expression<Func<TModel, bool>> predicate);
        Task<Resultado> SaveAsync();
    }
}
