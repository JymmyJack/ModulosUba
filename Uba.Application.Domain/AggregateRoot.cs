using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events;

namespace Uba.Application.Domain
{
    public class AggregateRoot : IEventProvider
    {
        private readonly List<Event> _changes;

        public AggregateRoot()
        {
            _changes = new List<Event>();
        }

        protected void ApplyChange(Event @event)
        {
            ApplyChange(@event, true);
        }

        private void ApplyChange(Event @event, bool isNew)
        {
            dynamic d = this;
            var eventHandle = ChangeTo(@event, @event.GetType());
            d.Handle(eventHandle);
            _changes.Add(@event);
        }

        public IEnumerable<Event> GetUncommittedChanges()
        {
            return _changes;
        }

        public void LoadsFromHistory(IEnumerable<Event> history)
        {
            throw new NotImplementedException();
        }


        private static dynamic ChangeTo(dynamic source, Type dest)
        {

            return System.Convert.ChangeType(source, dest);
        }
    }
}
