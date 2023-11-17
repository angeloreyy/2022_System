using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatabaseSample
{
    public partial class Sales : Form
    {
        public static string sendtext;
        public string data = "";
        public string orderNo;

        public Sales()
        {
            InitializeComponent();
        }
       
        public void clearfields()

        {
            txtOrderNo.Clear();
            txtCustomerName.Clear();
            txtDateSale.Clear();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            txtName.Text = Login.sendtext;
            data = "SELECT * FROM [sales_master]";
            DBHelper.DBHelper.fill(data, dgvSales);
            GetMaxItemNo.GetData.GetMaxOrderNumber();
            orderNo = GetMaxItemNo.GlobalDeclaration.OrderNumber.ToString();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            data = "DELETE * FROM [sales_master] WHERE [OrderNumber] = '" + txtOrderNo.Text + "' ";
            DBHelper.DBHelper.ModifyRecord(data);
            MessageBox.Show("Sales data successfully deleted", "Sales Master", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Sales_Load(sender, e);
            clearfields();
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderNo.Text      = dgvSales[0, e.RowIndex].Value.ToString();
            txtCustomerName.Text = dgvSales[1, e.RowIndex].Value.ToString();
            txtDateSale.Text     = dgvSales[2, e.RowIndex].Value.ToString();
        }
        private void btnBacktoStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Store s = new Store();
            s.Show();
            this.Hide();
        }
    }
}
