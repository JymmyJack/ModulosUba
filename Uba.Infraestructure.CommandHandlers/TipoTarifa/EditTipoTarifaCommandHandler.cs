using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Commands.Parametricas;
using Uba.Application.Commands.TipoTarifa;
using Uba.Application.Domain;
using Uba.Storage.Core;

namespace Uba.Application.Infraestructure.CommandHandlers.TipoTarifa
{
    public class EditTipoTarifaCommandHandler : ICommandHandler<EditTipoTarifaCommand>
    {

        private IRepository<TipoTarifaItem> _repository;

        public EditTipoTarifaCommandHandler(IRepository<TipoTarifaItem> repository)
        {
            _repository = repository;
        }

        public void Execute(EditTipoTarifaCommand command)
        {
            if (command is null) throw new ArgumentNullException(nameof(command));
            if (_repository is null) throw new InvalidOperationException("Repositorio no fue inicializado.");
            var aggregate = new TipoTarifaItem();
            aggregate.Update(command.TipoTarifaId, command.Descripcion, command.AplicaGrupoBin, command.AplicaDifTxn, command.Esquema);
            _repository.Save(aggregate);
        }
    }
}
