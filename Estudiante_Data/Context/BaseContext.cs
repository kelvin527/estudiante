
using Estudiante_Data.Entidades;
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
        public   DbSet<Calificaciones>  Calificaciones { get; set; }

         public  DbSet<Docentes> Docentes { get; set; }

         public  DbSet<Estudiantes> Estudiantes { get; set; }

         public  DbSet<Grados> Grados { get; set; }

         public  DbSet<Materias> Materias { get; set; }

         public  DbSet<Periodos> Periodos { get; set; }
       
    }
}
