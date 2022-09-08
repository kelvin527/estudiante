using Estudiante_Business.Dtos;
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
        public int GradoId { get; set; }
        public int PeriodoId { get; set; }
        public int Nota { get; set; }
        public EstudianteDto Estudiante { get; set; }
        public MateriaDto Materia { get; set; }
        public DocenteDto Docente { get; set; }
        public GradoDto Grado { get; set; }
        public PeriodoDto Periodo { get; set; }
    }
}
