using System;
using Uba.Application.Commands.CodigoAgrupacion;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.CodigoAgrupacion
{
    public class EditCodigoAgrupacionCommandHandler : ICommandHandler<EditCodigoAgrupacionCommand>
    {
        private IRepository<CodigoAgrupacionItem> _repository;

        public EditCodigoAgrupacionCommandHandler(IRepository<CodigoAgrupacionItem> repository)
        {
            _repository = repository;
        }

        public void Execute(EditCodigoAgrupacionCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new CodigoAgrupacionItem();
            aggregate.Update(command.Id, command.IdClase, command.Descripcion, command.Descripcion513);
            _repository.Save(aggregate);
        }
    }
}
