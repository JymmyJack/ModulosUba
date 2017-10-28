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
    public class EditTransaccionAgrupacionCommandHandler : ICommandHandler<EditTransaccionAgrupacionCommand>
    {
        private IRepository<TransaccionAgrupacionItem> _repository;

        public EditTransaccionAgrupacionCommandHandler(IRepository<TransaccionAgrupacionItem> repository)
        {
            _repository = repository;
        }
        public void Execute(EditTransaccionAgrupacionCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new TransaccionAgrupacionItem();
            aggregate.Update(command.IdClase, command.IdAgrupacion, command.IdTransaccion);
            _repository.Save(aggregate);
        }
    }
}
