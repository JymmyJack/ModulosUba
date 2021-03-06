﻿using Uba.Application.Events.CodigoAgrupacion;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.EventHandlers.CodigoAgrupacion
{
    public class CodigoAgrupacionEditedEventHandler : IEventHandler<CodigoAgrupacionEditedEvent>
    {
        private readonly IDbEntity<CodigoAgrupacionDto> _dbEntity;

        public CodigoAgrupacionEditedEventHandler(IDbEntity<CodigoAgrupacionDto> dbEntity)
        {
            _dbEntity = dbEntity;
        }

        public void Handle(CodigoAgrupacionEditedEvent handle)
        {
            _dbEntity.Edit(new CodigoAgrupacionDto
            {
                Descripcion = handle.Descripcion,
                Descripcion513 = handle.Descripcion513,
                Id = handle.Id,
                IdClase = handle.IdClase
            });
        }
    }
}
