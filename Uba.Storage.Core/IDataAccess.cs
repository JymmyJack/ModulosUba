using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Uba.Storage.Core
{
    public interface IDataAccess : IDisposable
    {
        #region Property Declaration

        bool AutoConnection
        {
            get;
            set;
        }

        string ConnectionString
        {
            get;
        }
        # endregion

        # region Open and Close Connection Declaration Section

        void OpenConnection();

        void CloseConnection();

        # endregion

        # region Data Selection Functions

        void GetDataSet(string SQLQuery, out DataSet Result);

        void GetDataSet(string SQLQuery, DataSet Result);

        void GetDataTable(string SQLQuery, out DataTable Result);

        void GetDataTable(string SQLQuery, DataTable Result);

        void GetDataReader(string SQLQuery, out IDataReader Result);

        void GetScalarValue(string SQLQuery, out string Result);

        void GetXMLReader(string strSQLQuery, out XmlReader xmlReaderResult);

        # endregion

        # region Data Manipulation Functions

        void ExecuteQuery(string SQLQuery, out int Result);

        void BatchUpdate(DataSet DataSetToBeUpdated);

        void BatchUpdate(DataTable DataTableToBeUpdated);

        int MannualBatchUpdate(DataTable DataTableToBeUpdated, IDbCommand InsertCommand, IDbCommand UpdateCommand, IDbCommand DeleteCommand);

        IDataParameter CreateParameter(string ParamName, DbType ParamType, int ParamSize, ParameterDirection ParamDirection, string SourceColumn);

        IDbCommand CreateCommand(string strQueryOrSP, CommandType commandType);

        # endregion

        # region Stored Procedures' related functions

        void RunStoredProcedure(string ProcedureName);

        void RunStoredProcedure(string ProcedureName, IDataParameter[] arrParameter);

        void RunStoredProcedure(string ProcedureName, out int Result);

        void RunStoredProcedure(string ProcedureName, out IDataReader DataReader);

        void RunStoredProcedure(string ProcedureName, out DataSet oDataSet);

        void RunStoredProcedure(string ProcedureName, DataSet oDataSet);

        void RunStoredProcedure(string ProcedureName, out DataTable oDataTable);

        void RunStoredProcedure(string ProcedureName, DataTable oDataTable);

        void RunStoredProcedure(string ProcedureName, out int Result, IDataParameter[] Parameter);

        void RunStoredProcedure(string ProcedureName, out int Result, IDataParameter[] Parameter, int intCommandTimeOut);

        void RunStoredProcedure(string ProcedureName, out IDataReader DataReader, IDataParameter[] Parameter);

        void RunStoredProcedure(string ProcedureName, out DataSet oDataSet, IDataParameter[] Parameter);

        void RunStoredProcedure(string ProcedureName, DataSet oDataSet, IDataParameter[] Parameter);

        void RunStoredProcedure(string ProcedureName, out DataTable oDataTable, IDataParameter[] Parameter);

        void RunStoredProcedure(string ProcedureName, DataTable oDataTable, IDataParameter[] Parameter);

        void RunStoredProcedure(string strProcedureName, out XmlReader xmlReaderResult);

        void RunStoredProcedure(string strProcedureName, out XmlReader xmlReaderResult, IDataParameter[] arrSqlParameter);

        void RunStoredProcedure(string strProcedureName, out object objScalarResult);

        void RunStoredProcedure(string strProcedureName, out object objScalarResult, IDataParameter[] arrSqlParameter);

        # endregion

        # region Commit and Rollback Functions

        void BeginTransaction(IsolationLevel IsoLevel);

        void BeginTransaction(string strNameOfTransaction, IsolationLevel objIsoLevel);

        void RollbackTransaction();

        void RollbackTransaction(string strNameOfTransactionORSavePoint);

        void CommitTransaction();

        void SetSavePoint(string strSavePointName);

        # endregion
    }
}
