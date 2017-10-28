using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Application.Messaging;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Application.Configuration
{
    public sealed class ServiceActivator
    {
        static ICommandBus _commandBus;
        static IDbEntity<ParametricaDto> _parametricaEntity;
        private static bool _isInitialized;
        private static readonly object _lockThis = new object();


        static ServiceActivator()
        {
            if (!_isInitialized)
            {
                lock (_lockThis)
                {
                    InversorConfig.RegisterIoCMap();
                    _commandBus = ObjectFactory.GetInstance<ICommandBus>();
                    _parametricaEntity = ObjectFactory.GetInstance<IDbEntity<ParametricaDto>>();
                    _isInitialized = true;
                }
            }
        }

        public static ICommandBus CommandBus { get => _commandBus; }

        public static IDbEntity<ParametricaDto> ParametricaEntity { get => _parametricaEntity; }
    }
}
