using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatabaseSample.Connection
{
    class Connection
    {
        public static OleDbConnection connect;
        private static string DBConnection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Inventory.accdb";

        public static void DB()
        {
            try
            {
                connect = new OleDbConnection(DBConnection);
                connect.Open();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
