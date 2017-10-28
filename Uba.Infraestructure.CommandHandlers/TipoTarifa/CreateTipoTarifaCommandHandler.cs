using System;
using Uba.Application.Domain;
using Uba.Infraestructure.Commands;
using Uba.Infraestructure.Commands.TipoTarifa;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.TipoTarifa
{
    public class CreateTipoTarifaCommandHandler : ICommandHandler<CreateTipoTarifaCommand>
    {
        private IRepository<TipoTarifaItem> _repository;

        public CreateTipoTarifaCommandHandler(IRepository<TipoTarifaItem> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateTipoTarifaCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new TipoTarifaItem(command.TipoTarifaId,command. );
            _repository.Save(aggregate);
        }
    }
}
