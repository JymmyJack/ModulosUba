﻿using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.EventHandlers;
using Uba.Application.Events;

namespace Uba.Application.Infraestructure.Utils
{
    public class StructureMapEventHandlerFactory : IEventHandlerFactory
    {
        public IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event
        {
            var handlers = GetHandlerType<T>();
            var lstHandlers = handlers.Select(handler => (IEventHandler<T>)ObjectFactory.GetInstance(handler)).ToList();
            return lstHandlers;
        }

        private static IEnumerable<Type> GetHandlerType<T>() where T : Event
        {
            var handlers = typeof(IEventHandler<>).Assembly.GetExportedTypes()
                    .Where(x => x.GetInterfaces()
                    .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(IEventHandler<>)))
                    .Where(h => h.GetInterfaces()
                    .Any(ii => ii.GetGenericArguments()
                    .Any(aa => aa == typeof(T)))).ToList();
            return handlers;
        }
    }
}