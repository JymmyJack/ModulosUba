using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uba.Application.Events.Parametricas
{
    public class ParametricaCreatedEvent : Event
    {
        public int Id { get; internal set; }
        public string Descripcion { get; internal set; }

        public int TipoParametrica { get; internal set; }

        public ParametricaCreatedEvent(int id,int tipo, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
            TipoParametrica = tipo;
        }
    }
}
