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
    public partial class Register : Form
    {
        public static string sendtext;
        public string data = "";
        public string ID;

        public Register()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string confirmpass = txtConfirmpass.Text;
            
            if (password == confirmpass)
            {
                data = "INSERT INTO [signup] ([firstname], [lastname], [email], [address],  [username], [password]) VALUES" +
                      "('" + txtFirstname.Text + "'," + " '"
                      + txtLastname.Text + "'," + " '"
                      + txtEmail.Text + "'," + " '"
                      + txtAddress.Text + "'," + " '"
                      + txtUsername.Text + "'," + " '"
                      + txtPassword.Text + "')";
                DBHelper.DBHelper.ModifyRecord(data);
                MessageBox.Show("Account succcessfully registered", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearfields();
            }
            else
            {
                txtConfirmpass.Clear();
                MessageBox.Show("Password mismatch", "Registration Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearfields()

        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmpass.Clear();
        }

        private void btnBacktoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }
    }
}
