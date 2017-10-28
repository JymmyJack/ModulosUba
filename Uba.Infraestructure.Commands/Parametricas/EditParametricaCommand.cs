using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Commands.Parametricas
{
    public class EditParametricaCommand : Command
    {
        public int Id { get; set; }
        public int TipoParametrica { get; set; }
        public string Descripcion { get; set; }

        public EditParametricaCommand(int id, int tipo, string descripcion)
        {
            Id = id;
            TipoParametrica = tipo;
            Descripcion = descripcion;
        }
    }
}
