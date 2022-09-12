using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Models
{
    public class CalificacionesResponseModel
    {
        public string Estudiante { get; set; }
        public string Docente { get; set; }
        public string Sexo { get; set; }
        public string Grado { get; set; }
        public IEnumerable<CalificacionesModel> Calificaciones { get; set; }
    }
}
