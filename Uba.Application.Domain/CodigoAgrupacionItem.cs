using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events;
using Uba.Application.Events.CodigoAgrupacion;

namespace Uba.Application.Domain
{
    public class CodigoAgrupacionItem : AggregateRoot, IHandle<CodigoAgrupacionCreatedEvent>, IHandle<CodigoAgrupacionEditedEvent>, IHandle<CodigoAgrupacionDeletedEvent>
    {
        public int Id { get; set; }
        public int IdClase { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion513 { get; set; }

        public CodigoAgrupacionItem()
        {

        }

        public CodigoAgrupacionItem(int id, int idClase, string descripcion, string descripcion513)
        {
            Id = id;
            IdClase = idClase;
            Descripcion = descripcion;
            Descripcion513 = descripcion513;
            ApplyChange(new CodigoAgrupacionCreatedEvent(id, idClase, descripcion, descripcion513));
        }

        public void Handle(CodigoAgrupacionCreatedEvent e)
        {
            Id = e.Id;
            IdClase = e.IdClase;
            Descripcion = e.Descripcion;
            Descripcion513 = e.Descripcion513;
        }

        public void Handle(CodigoAgrupacionEditedEvent e)
        {
            Id = e.Id;
            IdClase = e.IdClase;
            Descripcion = e.Descripcion;
            Descripcion513 = e.Descripcion513;
        }

        public void Handle(CodigoAgrupacionDeletedEvent e)
        {
            Id = e.Id;
            IdClase = e.IdClase;
        }

        public void Update(int id, int idClase, string descripcion, string descripcion513)
        {
            ApplyChange(new CodigoAgrupacionEditedEvent(id, idClase, descripcion, descripcion513));
        }

        public void Delete(int id, int idClase)
        {
            ApplyChange(new CodigoAgrupacionDeletedEvent(id, idClase));
        }
    }
}
