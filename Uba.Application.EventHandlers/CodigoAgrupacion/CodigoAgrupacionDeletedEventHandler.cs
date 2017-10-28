using Uba.Application.Events.CodigoAgrupacion;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.CodigoAgrupacion
{
    public class CodigoAgrupacionDeletedEventHandler : IEventHandler<CodigoAgrupacionDeletedEvent>
    {

        private readonly IDbEntity<CodigoAgrupacionDto> _dbEntity;

        public CodigoAgrupacionDeletedEventHandler(IDbEntity<CodigoAgrupacionDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(CodigoAgrupacionDeletedEvent handle)
        {
            _dbEntity.Delete(new CodigoAgrupacionDto
            {
                Id = handle.Id,
                IdClase = handle.IdClase
            });
        }
    }
}
