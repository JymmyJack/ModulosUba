using Uba.Application.Events;
using Uba.Application.Events.Parametricas;

using Uba.Application.Events.TipoTarifa;

namespace Uba.Application.Domain
{
    public class TipoTarifaItem : AggregateRoot,
                 IHandle<TipoTarifaCreatedEvent>,
                 IHandle<TipoTarifaEditedEvent>,
                 IHandle<TipoTarifaDeletedEvent>
    {
        public int TipoTarifaId { get; set; }
        public string Descripcion { get; set; }
        public bool AplicaGrupoBin { get; set; }
        public bool AplicaDifTxn { get; set; }
        public int Esquema { get; set; }

        public TipoTarifaItem()
        {

        }

        public void Handle(TipoTarifaCreatedEvent e)
        {
            TipoTarifaId = e.TipoTarifaId;
            Descripcion = e.Descripcion;
            AplicaGrupoBin = e.AplicaGrupoBin;
            AplicaDifTxn = e.AplicaDifTxn;
            Esquema = e.Esquema;
        }

        public void Handle(TipoTarifaEditedEvent e)
        {
            TipoTarifaId = e.TipoTarifaId;
            Descripcion = e.Descripcion;
            AplicaGrupoBin = e.AplicaGrupoBin;
            AplicaDifTxn = e.AplicaDifTxn;
            Esquema = e.Esquema;
        }

        public void Handle(TipoTarifaDeletedEvent e)
        {
            TipoTarifaId = e.TipoTarifaId;
            Descripcion = e.Descripcion;
            AplicaGrupoBin = e.AplicaGrupoBin;
            AplicaDifTxn = e.AplicaDifTxn;
            Esquema = e.Esquema;
        }

        public TipoTarifaItem(int id, string descripcion, bool aplicaBin, bool aplicaDifTxn, int esquema)
        {
            ApplyChange(new TipoTarifaCreatedEvent(id, descripcion, aplicaBin, aplicaDifTxn, esquema));
        }

        public void Update(int id, string descripcion, bool aplicaBin, bool aplicaDifTxn, int esquema)
        {
            ApplyChange(new TipoTarifaEditedEvent(id, descripcion, aplicaBin, aplicaDifTxn, esquema));
        }

        public void Delete(int id, string descripcion, bool aplicaBin, bool aplicaDifTxn, int esquema)
        {
            ApplyChange(new TipoTarifaDeletedEvent(id, descripcion, aplicaBin, aplicaDifTxn, esquema));
        }
    }
}
