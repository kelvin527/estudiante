using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Repository
{
    public interface IBase
    {
        public int Id { get; set; }
        public bool Estatus { get; set; }
    }
}
