using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Models
{
    public class Calificaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Estudiantes EstudianteId { get; set; }
        public Materias MateriaId { get; set; }
        public Docentes DocenteId { get; set; }
        public Grados GradoId { get; set; }
        public Periodos PeriodoId { get; set; }
        public int Nota { get; set; }
        public string Estatus { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FechaModificacion { get; set; }
    }
}
