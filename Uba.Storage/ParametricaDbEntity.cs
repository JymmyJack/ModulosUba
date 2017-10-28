using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uba.Infraestructure.Dto;
using Uba.Storage.Core;
using Dapper;
using System.Data;
using Uba.Storage.DatabaseStorage;
using System.Linq.Expressions;

namespace Uba.Storage
{
    public class ParametricaDbEntity : IDbEntity<ParametricaDto>
    {
        private readonly IDbConnection _connection;

        public ParametricaDbEntity(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Add(ParametricaDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_TIPO_TABLA", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.TipoParametrica);
            dbParameters.Add("V_ID_CONSTANTE", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            dbParameters.Add("V_DESCRIPCION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion);
            _connection.Execute("JTORRESN.PKG_CMI.SP_INS_CONSTANTE", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Delete(ParametricaDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_TIPO_TABLA", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.TipoParametrica);
            dbParameters.Add("V_ID_CONSTANTE", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            _connection.Execute("JTORRESN.PKG_CMI.SP_DEL_CONSTANTE", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public void Edit(ParametricaDto item)
        {
            var dbParameters = new OracleDynamicParameters();
            dbParameters.Add("V_TIPO_TABLA", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.TipoParametrica);
            dbParameters.Add("V_ID_CONSTANTE", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: item.Id);
            dbParameters.Add("V_DESCRIPCION", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2, direction: ParameterDirection.Input, value: item.Descripcion);
            _connection.Execute("JTORRESN.PKG_CMI.SP_UPD_CONSTANTE", param: dbParameters, commandType: CommandType.StoredProcedure);
        }

        public ParametricaDto GetById(ParametricaDto id)
        {
            throw new NotImplementedException();
        }

        public List<ParametricaDto> GetItems()
        {
            throw new NotImplementedException();
        }

        public List<ParametricaDto> GetItems(params object[] filters)
        {
            if (filters is null)
                throw new InvalidOperationException(nameof(filters));
            var lista = new List<ParametricaDto>();
            if (filters.Any())
            {
                var tipoTabla = Convert.ToInt32(filters[0]);
                var dbParameters = new OracleDynamicParameters();
                dbParameters.Add("V_TIPO_TABLA", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.Int32, direction: ParameterDirection.Input, value: tipoTabla);
                dbParameters.Add("CUR_PARAMS", dbType: Oracle.ManagedDataAccess.Client.OracleDbType.RefCursor, direction: ParameterDirection.Output);
                var listReturn = _connection.Query("jtorresn.PKG_CMI.SP_SEL_LISTAR_CONSTANTE", param: dbParameters, commandType: CommandType.StoredProcedure);
                lista = listReturn?.Select(row => new ParametricaDto
                {
                    Descripcion = row.DESCRIPCION,
                    Id = row.ID,
                    TipoParametrica = tipoTabla
                })?.ToList();
                return lista;
            }
            return lista;
        }
    }
}
