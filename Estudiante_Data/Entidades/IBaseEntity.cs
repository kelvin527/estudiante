using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Data.Entidades
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool Estatus { get; set; }
    }
}
