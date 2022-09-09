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
        public EstudianteDto Estudiante { get; set; }
        public DocenteDto Docente { get; set; }
        public int MateriaId { get; set; }
        public int DocenteId { get; set; }
        public int GradoId { get; set; }
        public int PeriodoId { get; set; }
        public int Nota { get; set; }
        public string Materia { get; set; }
        public string Grado { get; set; }
        public string Periodo { get; set; }
    }
}
