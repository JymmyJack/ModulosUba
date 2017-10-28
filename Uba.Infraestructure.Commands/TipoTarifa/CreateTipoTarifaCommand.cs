using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Commands.TipoTarifa
{
    public class CreateTipoTarifaCommand : Command
    {
        public int TipoTarifaId { get; set; }
        public string Descripcion { get; set; }
        public bool AplicaGrupoBin { get; set; }
        public bool AplicaDifTxn { get; set; }
        public int Esquema { get; set; }

        public CreateTipoTarifaCommand(int id, string descripcion, bool aplicaBin, bool aplicaDifTxn, int esquema)
        {
            TipoTarifaId = id;
            Descripcion = descripcion;
            AplicaGrupoBin = aplicaBin;
            AplicaDifTxn = aplicaDifTxn;
            Esquema = esquema;
        }
    }
}
