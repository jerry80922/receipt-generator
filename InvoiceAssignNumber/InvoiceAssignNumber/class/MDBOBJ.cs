using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace InvoiceAssignNumber
{
    class MDBOBJ
    {
        private OleDbConnection con;
        private OleDbTransaction trans;

        public MDBOBJ(string strDBPath)
        {
            con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + strDBPath);
        }
        #region DB Controll(DB操作)
        /// <summary>
        /// Open DB connect(開啟連線)
        /// </summary>
        /// <returns></returns>
        public bool OpenDB()
        {
            bool bln;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            bln = true;

            return bln;
        }

        /// <summary>
        /// Close DB connect(關閉連線)
        /// </summary>
        /// <returns></returns>
        public bool CloseDB()
        {
            bool bln;

            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            bln = true;

            return bln;
        }

        public void Dispose()
        {
            try
            {
                con.Close();
                con.Dispose();
            }
            catch { }
        }

        /// <summary>
        /// Check connect state(DB目前連線狀態)
        /// </summary>
        /// <returns></returns>
        public ConnectionState DBState()
        {
            return con.State;
        }

        /// <summary>
        /// Initiates DB transaction
        /// </summary>
        public void BeginTrans()
        {
            trans = con.BeginTransaction();
        }

        /// <summary>
        /// Commits the DB transaction
        /// </summary>
        public void CommitTrans()
        {
            if (trans != null)
            {
                trans.Commit();
            }
        }

        /// <summary>
        /// Rolls back a transaction from a pending state
        /// </summary>
        public void Rollback()
        {
            if (trans != null)
            {
                trans.Rollback();
                trans = null;
            }
        }
        #endregion

        public void InsertData(string tableName, List<string> colName, List<string> rowValue)
        {
            int count;
            string strSQL;
            OleDbCommand dbcmd;

            strSQL = "INSERT INTO " + tableName + "(" ;
            for (count = 0; count <= colName.Count - 1; count ++)
            {
                strSQL += colName[count].ToString() + ",";
            }
            strSQL = strSQL.Substring(0, strSQL.Length - 1) + ") VALUES(";
            for (count = 0; count <= rowValue.Count - 1; count++)
            {
                strSQL += "'" + rowValue[count].ToString().Replace("'", "''") + "',";
            }
            strSQL = strSQL.Substring(0, strSQL.Length - 1) + ");";

            dbcmd = new OleDbCommand(strSQL, con);
            if (trans != null)
            {
                dbcmd.Transaction = trans;
            }
            dbcmd.ExecuteNonQuery();
        }

        public string QueryData(string tableName, string colName, string strWH = "", string strOB = "")
        {
            DataTable dt;
            string strRtn, strSQL;

            strRtn = "";
            strSQL = "SELECT " + colName + " FROM " + tableName;
            if (strWH != "")
            {
                strSQL += " WHERE " + strWH;
            }
            if (strOB != "")
            {
                strSQL += " ORDER BY " + strOB;
            }

            OleDbDataAdapter dbadp = new OleDbDataAdapter(strSQL, con);
            if (trans != null)
            {
                dbadp.SelectCommand.Transaction = trans;
            }

            dt = new DataTable();
            dbadp.Fill(dt);
            dbadp.Dispose();

            if (dt.Rows.Count > 0)
            {
                strRtn = dt.Rows[0][0].ToString();
            }
            dt.Dispose();

            return strRtn;
        }

        public void DeleteData(string tableName)
        {
            string strSQL;
            OleDbCommand dbcmd;

            strSQL = "DELETE FROM " + tableName;

            dbcmd = new OleDbCommand(strSQL, con);
            if (trans != null)
            {
                dbcmd.Transaction = trans;
            }
            dbcmd.ExecuteNonQuery();
        }
    }
}