using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Dto
{
    public class CodigoAgrupacionDto : DtoBase
    {
        public int Id { get; set; }
        public int IdClase { get; set; }

        public string Descripcion { get; set; }

        public string Descripcion513 { get; set; }

        public string DescripcionClase { get; set; }

    }
}
