using Uba.Application.Events.CodigoAgrupacion;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.CodigoAgrupacion
{
    public class CodigoAgrupacionCreatedEventHandler : IEventHandler<CodigoAgrupacionCreatedEvent>
    {
        private readonly IDbEntity<CodigoAgrupacionDto> _dbEntity;

        public CodigoAgrupacionCreatedEventHandler(IDbEntity<CodigoAgrupacionDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(CodigoAgrupacionCreatedEvent handle)
        {
            _dbEntity.Add(new CodigoAgrupacionDto
            {
                Descripcion = handle.Descripcion,
                Descripcion513 = handle.Descripcion513,
                Id = handle.Id,
                IdClase = handle.IdClase
            });
        }
    }
}
