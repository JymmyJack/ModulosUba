using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.Parametricas
{
    public class ParametricaDeletedEvent : Event
    {
        public int Id { get; internal set; }
        public int TipoParametrica { get; internal set; }

        public ParametricaDeletedEvent(int id, int tipo)
        {
            Id = id;
            TipoParametrica = tipo;
        }
    }
}
