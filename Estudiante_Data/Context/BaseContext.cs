using Estudiante_Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Context
{
    public class BaseContext : DbContext
    {
      
        public BaseContext(DbContextOptions options) : base(options)
        {
        }
        public  virtual DbSet<Calificaciones>  Calificaciones { get; set; }

         public virtual DbSet<Docentes> Docentes { get; set; }

         public virtual DbSet<Estudiantes> Estudiantes { get; set; }

         public virtual DbSet<Grados> Grados { get; set; }

         public virtual DbSet<Materias> Materias { get; set; }

         public virtual DbSet<Periodos> Periodos { get; set; }

        public Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
