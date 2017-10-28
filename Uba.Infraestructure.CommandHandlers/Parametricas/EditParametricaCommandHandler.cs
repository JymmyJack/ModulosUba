using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Commands.Parametricas;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.Parametricas
{
    public class EditParametricaCommandHandler : ICommandHandler<EditParametricaCommand>
    {

        private IRepository<ParametricaItem> _repository;

        public EditParametricaCommandHandler(IRepository<ParametricaItem> repository)
        {
            _repository = repository;
        }

        public void Execute(EditParametricaCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new ParametricaItem();
            aggregate.Update(command.Id, command.TipoParametrica, command.Descripcion);
            _repository.Save(aggregate);
        }
    }
}
