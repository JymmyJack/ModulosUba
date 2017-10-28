using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.CodigoAgrupacion
{
    public class CodigoAgrupacionCreatedEvent : Event
    {
        public int Id { get; set; }
        public int IdClase { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion513 { get; set; }

        public CodigoAgrupacionCreatedEvent(int id, int idClase, string descripcion, string descripcion513)
        {
            Id = id;
            IdClase = idClase;
            Descripcion = descripcion;
            Descripcion513 = descripcion513;
        }
    }
}
