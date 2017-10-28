using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events;
using Uba.Application.Events.TransaccionAgrupacion;

namespace Uba.Application.Domain
{
    public class TransaccionAgrupacionItem : AggregateRoot, IHandle<TransaccionAgrupacionCreatedEvent>, IHandle<TransaccionAgrupacionEditedEvent>, IHandle<TransaccionAgrupacionDeletedEvent>
    {
        public int IdClase { get; set; }
        public int IdAgrupacion { get; set; }
        public int IdTransaccion { get; set; }

        public TransaccionAgrupacionItem()
        {

        }

        public TransaccionAgrupacionItem(int clase, int agrupacion, int transaccion)
        {
            IdClase = clase;
            IdAgrupacion = agrupacion;
            IdTransaccion = transaccion;
            ApplyChange(new TransaccionAgrupacionCreatedEvent(clase, agrupacion, transaccion));
        }

        public void Update(int clase, int agrupacion, int transaccion)
        {
            ApplyChange(new TransaccionAgrupacionEditedEvent(clase, agrupacion, transaccion));
        }

        public void Delete(int clase, int agrupacion, int transaccion)
        {
            ApplyChange(new TransaccionAgrupacionDeletedEvent(clase, agrupacion, transaccion));
        }

        public void Handle(TransaccionAgrupacionCreatedEvent e)
        {
            IdClase = e.IdClase;
            IdAgrupacion = e.IdAgrupacion;
            IdTransaccion = e.IdTransaccion;
        }

        public void Handle(TransaccionAgrupacionEditedEvent e)
        {
            IdClase = e.IdClase;
            IdAgrupacion = e.IdAgrupacion;
            IdTransaccion = e.IdTransaccion;
        }

        public void Handle(TransaccionAgrupacionDeletedEvent e)
        {
            IdClase = e.IdClase;
            IdAgrupacion = e.IdAgrupacion;
            IdTransaccion = e.IdTransaccion;
        }
    }
}
