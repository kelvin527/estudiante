using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Entidades
{
    public class Periodos : BaseEntity
    {
        public string Descripcion { get; set; }
    }
}
