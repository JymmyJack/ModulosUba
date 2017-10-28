using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.TipoTarifa
{
    public class TipoTarifaCreatedEvent : Event
    {
        public int TipoTarifaId { get; set; }
        public string Descripcion { get; set; }
        public bool AplicaGrupoBin { get; set; }
        public bool AplicaDifTxn { get; set; }
        public int Esquema { get; set; }

        public TipoTarifaCreatedEvent(int id, string descripcion, bool aplicaBin, bool aplicaDifTxn, int esquema)
        {
            TipoTarifaId = id;
            Descripcion = descripcion;
            AplicaGrupoBin = aplicaBin;
            AplicaDifTxn = aplicaDifTxn;
            Esquema = esquema;
        }
    }
}
