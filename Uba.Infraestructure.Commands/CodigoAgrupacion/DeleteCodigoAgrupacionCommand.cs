using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Commands.CodigoAgrupacion
{
    public class DeleteCodigoAgrupacionCommand : Command
    {

        public int Id { get; set; }
        public int IdClase { get; set; }

        public DeleteCodigoAgrupacionCommand(int id, int idClase)
        {
            Id = id;
            IdClase = idClase;
        }
    }
}
