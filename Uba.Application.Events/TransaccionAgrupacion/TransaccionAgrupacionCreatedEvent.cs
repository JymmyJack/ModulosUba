using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.TransaccionAgrupacion
{
    public class TransaccionAgrupacionCreatedEvent : Event
    {
        public int IdClase { get; set; }
        public int IdAgrupacion { get; set; }
        public int IdTransaccion { get; set; }


        public TransaccionAgrupacionCreatedEvent(int clase, int agrupacion, int transaccion)
        {
            IdClase = clase;
            IdAgrupacion = agrupacion;
            IdTransaccion = transaccion;
        }
    }
}
