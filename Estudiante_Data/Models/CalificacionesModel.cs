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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public EstudianteModel EstudianteId { get; set; }
        public MateriaModel MateriaId { get; set; }
        public DocenteModel DocenteId { get; set; }
        public GradoModel GradoId { get; set; }
        public PeriodoModel PeriodoId { get; set; }
        public int Nota { get; set; }
        public string Estatus { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FechaModificacion { get; set; }
    }
}
