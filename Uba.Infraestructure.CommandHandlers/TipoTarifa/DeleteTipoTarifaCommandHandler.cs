using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Commands.Parametricas;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.TipoTarifa
{
    public class DeleteTipoTarifaCommandHandler : ICommandHandler<DeleteTipoTarifaCommand>
    {

        private IRepository<TipoTarifaItem> _repository;

        public DeleteTipoTarifaCommandHandler(IRepository<TipoTarifaItem> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteTipoTarifaCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new TipoTarifaItem();
            aggregate.Delete(command.Id, command.TipoParametrica);
            _repository.Save(aggregate);
        }
    }
}
