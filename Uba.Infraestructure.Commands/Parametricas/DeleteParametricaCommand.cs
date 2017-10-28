using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Commands.Parametricas
{
    public class DeleteParametricaCommand : Command
    {
        public int Id { get; set; }
        public int TipoParametrica { get; set; }

        public DeleteParametricaCommand(int id, int tipo)
        {
            Id = id;
            TipoParametrica = tipo;
        }
    }
}
