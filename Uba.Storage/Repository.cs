using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Storage
{
    public class Repository<T> : IRepository<T> where T : AggregateRoot, new()
    {
        private readonly IEventStorage _storage;

        public Repository(IEventStorage storage)
        {
            _storage = storage;
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(AggregateRoot aggregate)
        {
            if (aggregate.GetUncommittedChanges().Any())
                _storage.Save(aggregate);
        }
    }
}
