using Estudiante_Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Dtos
{
    public class EstudianteDto : BaseDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}
