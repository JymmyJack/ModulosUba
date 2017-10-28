using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Uba.Application.Infraestructure.CommandHandlers;
using Uba.Infraestructure.Commands;

namespace Uba.Application.Infraestructure.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
