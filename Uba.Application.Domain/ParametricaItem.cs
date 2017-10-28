using Uba.Application.Events;
using Uba.Application.Events.Parametricas;

namespace Uba.Application.Domain
{
    public class ParametricaItem : AggregateRoot,
                 IHandle<ParametricaCreatedEvent>,
                 IHandle<ParametricaEditedEvent>,
                 IHandle<ParametricaDeletedEvent>
    {
        public int Id { get; set; }
        public int TipoParametrica { get; set; }
        public string Descripcion { get; set; }

        public ParametricaItem()
        {

        }

        public void Handle(ParametricaCreatedEvent e)
        {
            Id = e.Id;
            TipoParametrica = e.TipoParametrica;
            Descripcion = e.Descripcion;
        }

        public void Handle(ParametricaEditedEvent e)
        {
            Id = e.Id;
            TipoParametrica = e.TipoParametrica;
            Descripcion = e.Descripcion;
        }

        public void Handle(ParametricaDeletedEvent e)
        {
            Id = e.Id;
            TipoParametrica = e.TipoParametrica;
        }

        public ParametricaItem(int idGrupo, int tipo, string descripcion)
        {
            ApplyChange(new ParametricaCreatedEvent(idGrupo, tipo, descripcion));
        }

        public void Update(int id, int tipo, string descripcion)
        {
            ApplyChange(new ParametricaEditedEvent(id, tipo, descripcion));
        }

        public void Delete(int id, int tipo)
        {
            ApplyChange(new ParametricaDeletedEvent(id, tipo));
        }
    }
}
