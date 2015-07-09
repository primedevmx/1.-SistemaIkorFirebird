using System;
using System.Data;
using System.Xml;
using System.Collections;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Configuration;
using Borland.Data;
using Borland.Data.Units;

using System.Data.SqlClient;
using System.Data.Common;


namespace FireBird.FirebirdHelper
{

    public class FirebirdHelperADO
    {

        public static DataSet ExecuteDataset(string strConnection, string commandText)
        {
            if (strConnection == null) throw new ArgumentNullException("connection");

            // Create a command and prepare it for execution
            DbConnection conn = new TAdoDbxInterBaseConnection();
            conn.ConnectionString = strConnection;

            DataSet dsReturnin = new DataSet();
            DataTable dt = new DataTable();
            string sql = commandText;
            try
            {

                DbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                conn.Open();

                DbDataReader myreader = cmd.ExecuteReader();
                dsReturnin.Tables.Add(dt);
                dsReturnin.Load(myreader, LoadOption.PreserveChanges, dsReturnin.Tables[0]);
                myreader.Close();
                conn.Close();
                conn.Dispose();
            }
            catch {
                dsReturnin = null;
                conn.Close();
                conn.Dispose();
            }

            return dsReturnin;
        }

        public static DataSet ExecuteDatasetTEST(string strConnection, string commandText)
        {
            if (strConnection == null) throw new ArgumentNullException("connection");

            // Create a command and prepare it for execution
            DbConnection conn = new TAdoDbxInterBaseConnection();
            conn.ConnectionString = strConnection;

            DataSet dsReturnin = new DataSet();
            DataTable dt = new DataTable();
            string sql = commandText;
          

                DbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                conn.Open();

                DbDataReader myreader = cmd.ExecuteReader();
                dsReturnin.Tables.Add(dt);
                dsReturnin.Load(myreader, LoadOption.PreserveChanges, dsReturnin.Tables[0]);
                myreader.Close();
                conn.Close();
                conn.Dispose();
         

            return dsReturnin;
        }


        public static DataSet ExecuteDataset_UPDT_COMMD(string strConnection, string commandText)
        {
            if (strConnection == null) throw new ArgumentNullException("connection");

            // Create a command and prepare it for execution
            DbConnection conn = new TAdoDbxInterBaseConnection();
            conn.ConnectionString = strConnection;

            DataSet dsReturnin = new DataSet();
            DataTable dt = new DataTable();
            string sql = commandText;
          

                DbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                conn.Open();


                DbDataAdapter adapter = new TAdoDbxDataAdapter();
                
                adapter.UpdateCommand = cmd;


                //BdpCommand CommIns = new BdpCommand("INSERT INTO TESTTABLE VALUES(?)", Conn);
                //BdpDataAdapter adapter
                //adapter.InsertCommand = CommIns; 
         

            return dsReturnin;
        }



    }
}
