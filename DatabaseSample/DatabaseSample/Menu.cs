using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSample
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            txtName.Text = Login.sendtext;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin")
            {
                Stock s = new Stock();
                this.Hide();
                s.Show();
            }
            else
            {

                MessageBox.Show("You dont have permission to access stock", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Store p = new Store();
            p.Show();
            this.Hide();
            
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
            
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin")
            {
                Sales s = new Sales();
                this.Hide();
                s.Show();
            }
            else
            {

                MessageBox.Show("You dont have permission to access sales", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
