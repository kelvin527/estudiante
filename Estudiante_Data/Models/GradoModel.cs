using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Models
{
    public class Grados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public string UsuarioRegistro { get; set; }
        public string FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FechaModificacion { get; set; }
    }
}

