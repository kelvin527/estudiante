using Estudiante_Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Context
{
    internal class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {
        }

             public DbSet<CalificacionesModel> calificaciones { get; set; }

             public DbSet<DocenteModel> docentes { get; set; }

             public DbSet<EstudianteModel> estudiantes { get; set; }

             public DbSet<GradoModel> grados { get; set; }

             public DbSet<MateriaModel> materias { get; set; }

             public DbSet<PeriodoModel> periodos { get; set; }
    }
}
