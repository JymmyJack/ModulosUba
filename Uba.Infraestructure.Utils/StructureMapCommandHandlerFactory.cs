using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events;
using Uba.Application.Infraestructure.CommandHandlers;
using StructureMap;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Infraestructure.Utils
{
    public class StructureMapCommandHandlerFactory : ICommandHandlerFactory
    {
        public ICommandHandler<T> GetHandler<T>() where T : Command
        {
            var handlers = GetHandlerType<T>().ToList();

            var cmdHandler = handlers.Select(handler =>
                (ICommandHandler<T>)ObjectFactory.GetInstance(handler)).FirstOrDefault();

            return cmdHandler;
        }

        private static IEnumerable<Type> GetHandlerType<T>() where T : Command
        {
            var handlers = typeof(ICommandHandler<>).Assembly.GetExportedTypes()
                        .Where(x => x.GetInterfaces()
                        .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(ICommandHandler<>)))
                        .Where(h => h.GetInterfaces()
                        .Any(ii => ii.GetGenericArguments()
                        .Any(aa => aa == typeof(T)))).ToList();
            return handlers;
        }
    }
}
