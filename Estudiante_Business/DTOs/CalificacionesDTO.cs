using Estudiante_Business.Dtos;
using Estudiante_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Dtos
{
    public class CalificacionesDto: BaseDto
    {
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public int DocenteId { get; set; }
        public int PeriodoId { get; set; }
        public int Nota { get; set; }
        public EstudianteDto Estudiante { get; set; }
        public MateriaDto Materia { get; set; }
        public DocenteDto Docente { get; set; }

        public PeriodoDto Periodo { get; set; }
        public IEnumerable<CalificacionesModel> Calificaciones { get; set; }
    }
}
