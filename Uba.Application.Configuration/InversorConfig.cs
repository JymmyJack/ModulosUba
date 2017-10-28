using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Uba.Storage.Core;
using Uba.Storage;
using Uba.Application.Messaging;
using Uba.Application.Infraestructure.Utils;
using Uba.Infraestructure.Dto;
using Uba.Storage.DatabaseStorage;

namespace Uba.Application.Configuration
{
    internal static class InversorConfig
    {
        public static void RegisterIoCMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For<IDbConnection>().Use<Oracle.ManagedDataAccess.Client.OracleConnection>().Ctor<string>().Is("User Id=jtorresn;Data Source=w_server_db;password=clave123;Pooling=true;Max Pool Size=2000;Min Pool Size=0;Connection Lifetime=0");
                x.For<IEventStorage>().Use<DataBaseEventStorage>();
                x.For<IEventBus>().Use<EventBus>();
                x.For<ICommandHandlerFactory>().Use<StructureMapCommandHandlerFactory>();
                x.For<IEventHandlerFactory>().Use<StructureMapEventHandlerFactory>();
                x.For<ICommandBus>().Use<CommandBus>();
                x.For<IEventBus>().Use<EventBus>();
                x.For(typeof(IRepository<>)).Use(typeof(Repository<>));

                x.For<IDbEntity<ParametricaDto>>().Use<ParametricaDbEntity>();
                x.For<IDbEntity<CodigoAgrupacionDto>>().Use<CodigoAgrupacionDbEntity>();
            });
        }
    }
}
