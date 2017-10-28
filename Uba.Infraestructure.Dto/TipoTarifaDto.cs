using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Dto
{
    public class TipoTarifaDto : DtoBase
    {
        public int TipoTarifaId { get; set; }
        public string Descripcion { get; set; }
        public bool AplicaGrupoBin { get; set; }
        public bool AplicaDifTxn { get; set; }
        public int Esquema { get; set; }
    }
}
