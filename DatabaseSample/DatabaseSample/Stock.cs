using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSample
{
    public partial class Stock : Form
    {
        public string data = "";

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            textBox1.Text = Login.sendtext;
            data = "SELECT * FROM stock";
            DBHelper.DBHelper.fill(data, dgvStock);
            GetMaxItemNo.GetData.GetMaxItem();
            txtItemNo.Text = GetMaxItemNo.GlobalDeclaration.ItemCode.ToString();
        }

        private void clearfields() 
        {
            cboCoffee.Text="";
            cboBeanType.Text = "";
            txtPrice.Clear();
            txtStock.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                data = "INSERT INTO stock (ItemCode,Coffee,BeanType,Price,StockAmount) VALUES" +
                    "('" + txtItemNo.Text + "'," + " '"
                    + cboCoffee.Text + "'," + " '"
                    + cboBeanType.Text + "'," + " '"
                    + txtPrice.Text + "'," + " '"
                    + txtStock.Text + "')";
                DBHelper.DBHelper.ModifyRecord(data);
                MessageBox.Show("Data has been added...", "Saved New Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Stock_Load(sender, e);
                clearfields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            data = "UPDATE stock SET Coffee = '" + cboCoffee.Text +
                            "', BeanType = '" + cboBeanType.Text +
                            "', Price = '" + txtPrice.Text +
                            "', StockAmount = '" + txtStock.Text +
                            "' WHERE ItemCode = '" + txtItemNo.Text + "' ";

            DBHelper.DBHelper.ModifyRecord(data);
            MessageBox.Show("Data has been updated...", "Updated Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Stock_Load(sender, e);
            clearfields();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult Option = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Option == DialogResult.Yes)
            {
                data = "DELETE * FROM stock WHERE ItemCode = '" + txtItemNo.Text + "' ";
                DBHelper.DBHelper.ModifyRecord(data);
                Stock_Load(sender, e);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clearfields();
            txtItemNo.Text = "SET stock ItemCode";
            DBHelper.DBHelper.ModifyRecord(data);
            Stock_Load(sender, e);
        }
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemNo.Text = dgvStock[0, e.RowIndex].Value.ToString();
            cboCoffee.Text = dgvStock[1, e.RowIndex].Value.ToString();
            cboBeanType.Text = dgvStock[2, e.RowIndex].Value.ToString();
            txtPrice.Text = dgvStock[3, e.RowIndex].Value.ToString();
            txtStock.Text = dgvStock[4, e.RowIndex].Value.ToString();
        }

        private void mainMenuToolStripMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }

        private void purchaseCoffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store p = new Store();
            this.Hide();
            p.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            cboCoffee.Items.Add(txtAddCoffee.Text);
            txtAddCoffee.Clear();
        }
        private void btnAddBeanType_Click(object sender, EventArgs e)
        {
            cboBeanType.Items.Add(txtAddBeanType.Text);
            txtAddBeanType.Clear();
        }

        private void btnRemoveCoffee_Click(object sender, EventArgs e)
        {
            if (cboCoffee.Items.Contains(txtAddCoffee.Text))
            {
                cboCoffee.Items.Remove(txtAddCoffee.Text);
                txtAddCoffee.Clear();
            }
            else
            {
                MessageBox.Show("Item cant be found", "Deletion Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnRemoveBeanType_Click(object sender, EventArgs e)
        {
            if (cboBeanType.Items.Contains(txtAddBeanType.Text))
            {
                cboCoffee.Items.Remove(txtAddBeanType.Text);
                txtAddBeanType.Clear();
            }
            else
            {
                MessageBox.Show("Item cant be found", "Deletion Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
