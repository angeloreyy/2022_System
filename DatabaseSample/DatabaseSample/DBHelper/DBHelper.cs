using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace DatabaseSample.DBHelper
{
    class DBHelper
    {
        public static string gen = "";
        public static OleDbConnection connect;
        public static OleDbCommand command;
        public static OleDbDataReader DBReader;

        public static void fill(string Query, DataGridView DGV) 
        {
            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(Query, Connection.Connection.connect);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                DGV.DataSource = dt;
                Connection.Connection.connect.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.connect.Close();
                MessageBox.Show(ex.Message, "Error FillGridDataView", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ModifyRecord(string Updates) 
        {
            try
            {
                Connection.Connection.DB();
                OleDbCommand command = new OleDbCommand(Updates, Connection.Connection.connect);
                command.ExecuteNonQuery();
                Connection.Connection.connect.Close();
            }
            catch (Exception ex) 
            {
                Connection.Connection.connect.Close();
                MessageBox.Show("Error ----> " + Updates + ex.Message);
            }
        }
    }
}
