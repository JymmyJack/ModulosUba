using Uba.Application.Events.Parametricas;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.Parametricas
{
    public class ParametricaCreatedEventHandler : IEventHandler<ParametricaCreatedEvent>
    {

        private readonly IDbEntity<ParametricaDto> _dbEntity;

        public ParametricaCreatedEventHandler(IDbEntity<ParametricaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(ParametricaCreatedEvent handle)
        {
            _dbEntity.Add(new ParametricaDto
            {
                Descripcion = handle.Descripcion,
                Id = handle.Id,
                TipoParametrica = handle.TipoParametrica
            });
        }
    }
}
