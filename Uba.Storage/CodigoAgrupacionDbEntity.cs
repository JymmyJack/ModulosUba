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
    public class CodigoAgrupacionDbEntity : IDbEntity<CodigoAgrupacionDto>
    {

        private readonly IDbConnection _connection;

        public CodigoAgrupacionDbEntity(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(CodigoAgrupacionDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_ID_CLASE_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            dbParameters.Add("V_ID_CODIGO_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.IdClase);
            dbParameters.Add("V_DESCRIPCION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion);
            dbParameters.Add("V_DESCRIPCION_T513", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion513);
            _connection.Execute("JTORRESN.PKG_CMI.SP_INS_COD_AGRUPACION", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Delete(CodigoAgrupacionDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_ID_CLASE_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            dbParameters.Add("V_ID_CODIGO_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.IdClase);
            _connection.Execute("JTORRESN.PKG_CMI.SP_DEL_COD_AGRUPACION", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Edit(CodigoAgrupacionDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_ID_CLASE_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            dbParameters.Add("V_ID_CODIGO_AGRUPACION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.IdClase);
            dbParameters.Add("V_DESCRIPCION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion);
            dbParameters.Add("V_DESCRIPCION_T513", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion513);
            _connection.Execute("JTORRESN.PKG_CMI.SP_UPD_COD_AGRUPACION", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public CodigoAgrupacionDto GetById(CodigoAgrupacionDto id)
        {
            throw new NotImplementedException();
        }

        public List<CodigoAgrupacionDto> GetItems()
        {
            var lista = new List<CodigoAgrupacionDto>();
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("CUR_PARAMS", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.RefCursor, direction: ParameterDirection.Output);
            var listReturn = _connection.Query("jtorresn.PKG_CMI.SP_SEL_COD_AGRUPACION", param: dbParameters, commandType: CommandType.StoredProcedure);
            lista = listReturn?.Select(row => new CodigoAgrupacionDto
            {
                Descripcion = row.DES_CODIGO_AGRUPACION,
                Descripcion513 = row.DESCRIPCION_T513,
                Id = row.codigo_agrupacion,
                DescripcionClase = row.DES_CLASE_AGRUPACION,
                IdClase = row.clase_agrupacion
            })?.ToList();
            return lista;
        }

        public List<CodigoAgrupacionDto> GetItems(params object[] filters)
        {
            throw new NotImplementedException();
        }
    }
}
