using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events.Parametricas;
using Uba.Application.Events.TipoParametrica;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.TipoTarifa
{
    public class TipoTarifaDeletedEventHandler : IEventHandler<TipoTarifaDeletedEvent>
    {

        private readonly IDbEntity<TipoTarifaDto> _dbEntity;

        public TipoTarifaDeletedEventHandler(IDbEntity<TipoTarifaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(TipoTarifaDeletedEvent handle)
        {
            _dbEntity.Delete(new TipoTarifaDto
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
