using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Commands.CodigoAgrupacion
{
    public class EditCodigoAgrupacionCommand : Command
    {
        public int Id { get; set; }
        public int IdClase { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion513 { get; set; }

        public EditCodigoAgrupacionCommand(int id, int idClase, string descripcion, string descripcion513)
        {
            Id = id;
            IdClase = idClase;
            Descripcion = descripcion;
            Descripcion513 = descripcion513;
        }
    }
}
