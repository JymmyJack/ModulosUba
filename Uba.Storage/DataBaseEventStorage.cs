using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Domain;
using Uba.Application.Infraestructure.Utils;
using Uba.Application.Messaging;
using Uba.Storage.Core;

namespace Uba.Storage
{
    public class DataBaseEventStorage : IEventStorage
    {

        private readonly IEventBus _eventBus;

        public DataBaseEventStorage(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Save(AggregateRoot aggregate)
        {
            var eventosPendientes = aggregate.GetUncommittedChanges();
            foreach (var evento in eventosPendientes)
            {
                var eventoExec = ChangeTo(evento, evento.GetType());
                _eventBus.Publish(eventoExec);
            }
        }


        private static dynamic ChangeTo(dynamic source, Type dest)
        {

            return System.Convert.ChangeType(source, dest);
        }
    }
}
