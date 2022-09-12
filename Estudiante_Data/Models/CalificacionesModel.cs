using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Models
{
    public class CalificacionesModel
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Materia { get; set; }
        public string Periodo { get; set; }
    }
}
