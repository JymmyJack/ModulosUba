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
    public class ParametricaDeletedEventHandler : IEventHandler<ParametricaDeletedEvent>
    {

        private readonly IDbEntity<ParametricaDto> _dbEntity;

        public ParametricaDeletedEventHandler(IDbEntity<ParametricaDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(ParametricaDeletedEvent handle)
        {
            _dbEntity.Delete(new ParametricaDto
            {
                Id = handle.Id,
                TipoParametrica = handle.TipoParametrica
            });
        }
    }
}
