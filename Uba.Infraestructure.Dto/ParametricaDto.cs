using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Dto
{
    public class ParametricaDto : DtoBase
    {
        public int Id { get; set; }

        public int TipoParametrica { get; set; }

        public string Descripcion { get; set; }
    }
}
