using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Commands.CodigoAgrupacion;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.CodigoAgrupacion
{
    public class DeleteCodigoAgrupacionCommandHandler : ICommandHandler<DeleteCodigoAgrupacionCommand>
    {
        private IRepository<CodigoAgrupacionItem> _repository;

        public DeleteCodigoAgrupacionCommandHandler(IRepository<CodigoAgrupacionItem> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteCodigoAgrupacionCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new CodigoAgrupacionItem();
            aggregate.Delete(command.Id, command.IdClase);
            _repository.Save(aggregate);
        }
    }
}
