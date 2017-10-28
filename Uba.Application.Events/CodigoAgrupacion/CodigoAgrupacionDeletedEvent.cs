using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.CodigoAgrupacion
{
    public class CodigoAgrupacionDeletedEvent : Event
    {
        public int Id { get; set; }
        public int IdClase { get; set; }
        public CodigoAgrupacionDeletedEvent(int id, int idClase)
        {
            Id = id;
            IdClase = idClase;
        }
    }
}
