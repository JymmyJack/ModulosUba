using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events.TransaccionAgrupacion;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.TransaccionAgrupacion
{
    public class TransaccionAgrupacionEditedEventHandler : IEventHandler<TransaccionAgrupacionEditedEvent>
    {
        private readonly IDbEntity<TransaccionAgrupacionDto> _dbEntity;

        public TransaccionAgrupacionEditedEventHandler(IDbEntity<TransaccionAgrupacionDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }


        public void Handle(TransaccionAgrupacionEditedEvent handle)
        {
            var dto = new TransaccionAgrupacionDto();
            dto.ClaseAgrupacion.Id = handle.IdClase;
            dto.CodigoAgrupacion.Id = handle.IdAgrupacion;
            dto.TipoTransaccion.Id = handle.IdTransaccion;
            _dbEntity.Edit(dto);
        }
    }
}
