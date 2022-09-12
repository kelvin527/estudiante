using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Entidades
{
    public class Calificaciones: BaseEntity
    {
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public int DocenteId { get; set; }

        public int PeriodoId { get; set; }
        public int Nota { get; set; }
        public Estudiantes Estudiante { get; set; }
        public Materias Materia { get; set; }
        public Docentes Docente { get; set; }
        public Periodos Periodo { get; set; }

    }
}
