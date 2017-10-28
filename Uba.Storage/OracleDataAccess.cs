using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Oracle.ManagedDataAccess.Client;
using Uba.Storage.Core;

namespace Uba.Storage.DatabaseStorage
{
    public class OracleDataAccess : IDataAccess
    {
        public bool AutoConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string ConnectionString => throw new NotImplementedException();

        public void BatchUpdate(DataSet DataSetToBeUpdated)
        {
            throw new NotImplementedException();
        }

        public void BatchUpdate(DataTable DataTableToBeUpdated)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction(IsolationLevel IsoLevel)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction(string strNameOfTransaction, IsolationLevel objIsoLevel)
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand(string strQueryOrSP, CommandType commandType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter CreateParameter(string ParamName, DbType ParamType, int ParamSize, ParameterDirection ParamDirection, string SourceColumn)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string SQLQuery, out int Result)
        {
            throw new NotImplementedException();
        }

        public void GetDataReader(string SQLQuery, out IDataReader Result)
        {
            throw new NotImplementedException();
        }

        public void GetDataSet(string SQLQuery, out DataSet Result)
        {
            throw new NotImplementedException();
        }

        public void GetDataSet(string SQLQuery, DataSet Result)
        {
            throw new NotImplementedException();
        }

        public void GetDataTable(string SQLQuery, out DataTable Result)
        {
            throw new NotImplementedException();
        }

        public void GetDataTable(string SQLQuery, DataTable Result)
        {
            throw new NotImplementedException();
        }

        public void GetScalarValue(string SQLQuery, out string Result)
        {
            throw new NotImplementedException();
        }

        public void GetXMLReader(string strSQLQuery, out XmlReader xmlReaderResult)
        {
            throw new NotImplementedException();
        }

        public int MannualBatchUpdate(DataTable DataTableToBeUpdated, IDbCommand InsertCommand, IDbCommand UpdateCommand, IDbCommand DeleteCommand)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction(string strNameOfTransactionORSavePoint)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, IDataParameter[] arrParameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out int Result)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out IDataReader DataReader)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out DataSet oDataSet)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, DataSet oDataSet)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out DataTable oDataTable)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, DataTable oDataTable)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out int Result, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out int Result, IDataParameter[] Parameter, int intCommandTimeOut)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out IDataReader DataReader, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out DataSet oDataSet, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, DataSet oDataSet, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, out DataTable oDataTable, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string ProcedureName, DataTable oDataTable, IDataParameter[] Parameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string strProcedureName, out XmlReader xmlReaderResult)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string strProcedureName, out XmlReader xmlReaderResult, IDataParameter[] arrSqlParameter)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string strProcedureName, out object objScalarResult)
        {
            throw new NotImplementedException();
        }

        public void RunStoredProcedure(string strProcedureName, out object objScalarResult, IDataParameter[] arrSqlParameter)
        {
            throw new NotImplementedException();
        }

        public void SetSavePoint(string strSavePointName)
        {
            throw new NotImplementedException();
        }
    }
}
