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
    public class CreateCodigoAgrupacionCommandHandler : ICommandHandler<CreateCodigoAgrupacionCommand>
    {

        private IRepository<CodigoAgrupacionItem> _repository;

        public CreateCodigoAgrupacionCommandHandler(IRepository<CodigoAgrupacionItem> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateCodigoAgrupacionCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new CodigoAgrupacionItem(command.Id, command.IdClase, command.Descripcion, command.Descripcion513);
            _repository.Save(aggregate);
        }
    }
}
