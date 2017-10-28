using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Domain;

namespace Uba.Storage.Core
{
    public interface IEventStorage
    {
        //IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        //T GetMemento<T>(Guid aggregateId) where T : BaseMemento;
        //void SaveMemento(BaseMemento memento);
    }
}
