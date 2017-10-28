using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Commands.TransaccionAgrupacion;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.TransaccionAgrupacion
{
    public class DeleteAgrupacionCommandHandler : ICommandHandler<DeleteTransaccionAgrupacionCommand>
    {
        private IRepository<TransaccionAgrupacionItem> _repository;

        public DeleteAgrupacionCommandHandler(IRepository<TransaccionAgrupacionItem> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteTransaccionAgrupacionCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new TransaccionAgrupacionItem();
            aggregate.Delete(command.IdClase, command.IdAgrupacion, command.IdTransaccion);
            _repository.Save(aggregate);
        }
    }
}
