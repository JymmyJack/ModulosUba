using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Events.Parametricas;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.Parametricas
{
    public class ParametricaEditedEventHandler : IEventHandler<ParametricaEditedEvent>
    {
        private readonly IDbEntity<ParametricaDto> _dbEntity;

        public ParametricaEditedEventHandler(IDbEntity<ParametricaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(ParametricaEditedEvent handle)
        {
            _dbEntity.Edit(new ParametricaDto
            {
                Descripcion = handle.Descripcion,
                Id = handle.Id,
                TipoParametrica = handle.TipoParametrica
            });
        }
    }
}
