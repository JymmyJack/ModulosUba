using Uba.Application.Events.Parametricas;
using Uba.Application.Events.TipoParametrica;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.TipoTarifa
{
    public class TipoTarifaCreatedEventHandler : IEventHandler<TipoTarifaCreatedEvent>
    {

        private readonly IDbEntity<TipoTarifaDto> _dbEntity;

        public TipoTarifaCreatedEventHandler(IDbEntity<TipoTarifaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(TipoTarifaCreatedEvent handle)
        {
            _dbEntity.Add(new TipoTarifaDto
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
