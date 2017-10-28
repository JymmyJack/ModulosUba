using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Dto
{
    public class TransaccionAgrupacionDto : DtoBase
    {
        public ParametricaDto ClaseAgrupacion { get; set; } = new ParametricaDto();
        public ParametricaDto CodigoAgrupacion { get; set; } = new ParametricaDto();
        public ParametricaDto TipoTransaccion { get; set; } = new ParametricaDto();

    }
}
