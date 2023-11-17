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
    public partial class Login : Form
    {
        public static string sendtext;
        public string data = "";

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                DBHelper.DBHelper.gen = "SELECT * FROM users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ";
                DBHelper.DBHelper.command = new OleDbCommand(DBHelper.DBHelper.gen, Connection.Connection.connect);
                DBHelper.DBHelper.DBReader = DBHelper.DBHelper.command.ExecuteReader();

                if (DBHelper.DBHelper.DBReader.HasRows)
                {
                    DBHelper.DBHelper.DBReader.Read();
                    txtUsername.Text = (DBHelper.DBHelper.DBReader["username"].ToString());
                    txtPassword.Text = (DBHelper.DBHelper.DBReader["password"].ToString());

                    MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sendtext = txtUsername.Text;

                    TimerLogin.Enabled = true;
                    TimerLogin.Start();
                    TimerLogin.Interval = 1;
                    ProgressBarLogin.Maximum = 200;
                    TimerLogin.Tick += new EventHandler(TimerLogin_Tick);
                }
                else if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
                {
                    Connection.Connection.DB();
                    DBHelper.DBHelper.gen = "SELECT * FROM signup WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ";
                    DBHelper.DBHelper.command = new OleDbCommand(DBHelper.DBHelper.gen, Connection.Connection.connect);
                    DBHelper.DBHelper.DBReader = DBHelper.DBHelper.command.ExecuteReader();

                    if (DBHelper.DBHelper.DBReader.HasRows)
                    {
                        DBHelper.DBHelper.DBReader.Read();
                        txtUsername.Text = (DBHelper.DBHelper.DBReader["username"].ToString());
                        txtPassword.Text = (DBHelper.DBHelper.DBReader["password"].ToString());

                        MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sendtext = txtUsername.Text;

                        timer1.Enabled = true;
                        timer1.Start();
                        timer1.Interval = 1;
                        ProgressBarLogin.Maximum = 200;
                        timer1.Tick += new EventHandler(timer1_Tick);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Connection.Connection.connect.Close();
                }
            }
            catch (Exception ex)
            {
                Connection.Connection.connect.Close();
                MessageBox.Show(ex.Message, "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerLogin_Tick(object sender, EventArgs e)
        {
            if (ProgressBarLogin.Value != 200) 
            { 
                ProgressBarLogin.Value++; 
            }
            else
            {
                TimerLogin.Stop();
                ProgressBarLogin.Value = 0;
                Menu m = new Menu();
                m.Show();
                this.Hide();

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBarLogin.Value != 200)
            {
                ProgressBarLogin.Value++;
            }
            else
            {
                timer1.Stop();
                ProgressBarLogin.Value = 0;
                Store s = new Store();
                s.Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}
