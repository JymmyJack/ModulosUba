using System;
using Uba.Application.Domain;
using Uba.Infraestructure.Commands;
using Uba.Infraestructure.Commands.Parametricas;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.Parametricas
{
    public class CreateParametricaCommandHandler : ICommandHandler<CreateParametricaCommand>
    {
        private IRepository<ParametricaItem> _repository;

        public CreateParametricaCommandHandler(IRepository<ParametricaItem> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateParametricaCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new ParametricaItem(command.Id, command.TipoParametrica, command.Descripcion);
            _repository.Save(aggregate);
        }
    }
}
