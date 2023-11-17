using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DatabaseSample.GetMaxItemNo
{
    class GetData
    {
        public static void GetMaxItem()
        {
            try
            {
                string sql = "SELECT MAX(ItemCode) FROM stock";

                Connection.Connection.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connection.Connection.connect);
                GlobalDeclaration.DBReader = GlobalDeclaration.command.ExecuteReader();

                if (GlobalDeclaration.DBReader.Read())
                {
                    sql = GlobalDeclaration.DBReader[0].ToString();

                    if (sql == "")
                    {
                        GlobalDeclaration.ItemCode = 1;
                    }
                    else
                    {
                        GlobalDeclaration.ItemCode = Convert.ToInt32(GlobalDeclaration.DBReader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.DBReader.Close();
                }
                Connection.Connection.connect.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.connect.Close();
                MessageBox.Show("Error ----> GET MAX ID " + ex.Message);
            }
        }
        public static void GetMaxOrderNumber()
        {
            try
            {
                string sql = "SELECT MAX(OrderNumber) FROM [sales_master]";

                Connection.Connection.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connection.Connection.connect);
                GlobalDeclaration.DBReader = GlobalDeclaration.command.ExecuteReader();

                if (GlobalDeclaration.DBReader.Read())
                {
                    sql = GlobalDeclaration.DBReader[0].ToString();

                    if (sql == "")
                    {
                        GlobalDeclaration.OrderNumber = 10001;
                    }
                    else
                    {
                        GlobalDeclaration.OrderNumber = Convert.ToInt32(GlobalDeclaration.DBReader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.DBReader.Close();
                }
                Connection.Connection.connect.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.connect.Close();
                MessageBox.Show("Error ----> GET MAX ORNo " + ex.Message);
            }
        }
    }
}
