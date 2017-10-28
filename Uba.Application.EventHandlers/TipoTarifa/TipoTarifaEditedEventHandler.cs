using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events.Parametricas;
using Uba.Application.Events.TipoTarifa;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.TipoTarifa
{
    public class TipoTarifaEditedEventHandler : IEventHandler<TipoTarifaEditedEvent>
    {
        private readonly IDbEntity<TipoTarifaDto> _dbEntity;

        public TipoTarifaEditedEventHandler(IDbEntity<TipoTarifaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(TipoTarifaEditedEvent handle)
        {
            _dbEntity.Edit(new TipoTarifaDto
            {
                Descripcion = handle.Descripcion,
                TipoTarifaId = handle.TipoTarifaId,
                AplicaDifTxn = handle.AplicaDifTxn,
                AplicaGrupoBin = handle.AplicaGrupoBin,
                Esquema = handle.Esquema
            });
        }
    }
}
