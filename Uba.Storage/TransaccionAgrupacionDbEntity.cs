using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;

namespace Uba.Storage.DatabaseStorage
{
    public class TransaccionAgrupacionDbEntity : IDbEntity<TransaccionAgrupacionDto>
    {
        private readonly IDbConnection _connection;
        public TransaccionAgrupacionDbEntity(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(TransaccionAgrupacionDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_ID_CLASE_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.ClaseAgrupacion.Id);
            dbParameters.Add("V_ID_CODIGO_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.CodigoAgrupacion.Id);
            dbParameters.Add("V_ID_TIPO_TRANSACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.TipoTransaccion.Id);
            _connection.Execute("JTORRESN.PKG_CMI.SP_INS_TRAN_AGR", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Delete(TransaccionAgrupacionDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_ID_CLASE_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.ClaseAgrupacion.Id);
            dbParameters.Add("V_ID_CODIGO_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.CodigoAgrupacion.Id);
            dbParameters.Add("V_ID_TIPO_TRANSACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.TipoTransaccion.Id);
            _connection.Execute("JTORRESN.PKG_CMI.SP_DEL_TRAN_AGR", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Edit(TransaccionAgrupacionDto item)
        {
            throw new NotImplementedException();
        }

        public TransaccionAgrupacionDto GetById(TransaccionAgrupacionDto id)
        {
            throw new NotImplementedException();
        }

        public List<TransaccionAgrupacionDto> GetItems()
        {
            var lista = new List<TransaccionAgrupacionDto>();
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("CUR_PARAMS", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.RefCursor, direction: ParameterDirection.Output);
            var listReturn = _connection.Query("jtorresn.PKG_CMI.SP_SEL_LISTAR_TRAN_AGR", param: dbParameters, commandType: CommandType.StoredProcedure);
            lista = listReturn?.Select(row => new TransaccionAgrupacionDto
            {
                ClaseAgrupacion = new ParametricaDto
                {
                    Id = row.clase_agrupacion,
                    Descripcion = row.CLASE_AGRUPACION
                },
                CodigoAgrupacion = new ParametricaDto
                {
                    Id = row.codigo_agrupacion,
                    Descripcion = row.CODIGO_AGRUPACION
                },
                TipoTransaccion = new ParametricaDto
                {
                    Id = row.tipo_transaccion,
                    Descripcion = row.TIPO_TRANSACCION
                }
            })?.ToList();
            return lista;
        }

        public List<TransaccionAgrupacionDto> GetItems(params object[] filters)
        {
            throw new NotImplementedException();
        }
    }
}
