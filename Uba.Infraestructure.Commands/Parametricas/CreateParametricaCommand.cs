using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Infraestructure.Commands.Parametricas
{
    public class CreateParametricaCommand : Command
    {
        public int Id { get; set; }
        public int TipoParametrica { get; set; }
        public string Descripcion { get; set; }

        public CreateParametricaCommand(int id, int tipo, string descripcion)
        {
            Id = id;
            TipoParametrica = tipo;
            Descripcion = descripcion;
        }
    }
}
