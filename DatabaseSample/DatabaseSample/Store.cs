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
using System.Diagnostics;
using System.Drawing.Printing;

namespace DatabaseSample
{
    public partial class Store : Form
    {
        public string data = "";
        public string orderNo;

        public Store()
        {
            InitializeComponent();
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            txtLoggedName.Text = Login.sendtext;
            data = "SELECT * FROM stock";
            DBHelper.DBHelper.fill(data, dgvStock);
            GetMaxItemNo.GetData.GetMaxItem();
            GetMaxItemNo.GetData.GetMaxOrderNumber();
            orderNo = GetMaxItemNo.GlobalDeclaration.OrderNumber.ToString();
        }

        private void clearfields() 
        {
            txtCoffee.Clear();
            txtBeantype.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtQuantity.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            txtCash.Clear();
            txtChange.Clear();
        }
        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemNo.Text = dgvStock[0, e.RowIndex].Value.ToString();
            txtCoffee.Text = dgvStock[1, e.RowIndex].Value.ToString();
            txtBeantype.Text = dgvStock[2, e.RowIndex].Value.ToString();
            txtPrice.Text = dgvStock[3, e.RowIndex].Value.ToString();
            txtStock.Text = dgvStock[4, e.RowIndex].Value.ToString();
            txtQuantity.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int stock = Convert.ToInt32(txtStock.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double subtotal;
                if (quantity > stock)
                {
                    MessageBox.Show("Quantity is more than available stock", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Convert.ToDouble(quantity);
                    
                    double price = Convert.ToDouble(txtPrice.Text);

                    subtotal = price * quantity;

                    txtSubtotal.Text = subtotal.ToString("N2");
                    dgvOrder.Rows.Add(txtItemNo.Text, txtCoffee.Text, txtBeantype.Text, txtPrice.Text, txtQuantity.Text, subtotal.ToString());
                    Stock_Load(sender, e);
                    //clearfields();
                }
            }
            catch
            {
                MessageBox.Show("Enter number of quantity", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < dgvOrder.RowCount; i++)
            {
                total += Convert.ToDouble(dgvOrder.Rows[i].Cells[5].Value);
            }
            txtTotal.Text = total.ToString("N2");
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                double cash = Convert.ToDouble(txtCash.Text);
                txtCash.Text = cash.ToString("N2");
                double total = Convert.ToDouble(txtTotal.Text);
                double change;

                if (total > cash)
                {
                    MessageBox.Show("Your payment is short", "Purchase Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    change = cash - total;

                    txtChange.Text = change.ToString("N2");

                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        string itemNo   = dgvOrder.Rows[i].Cells[0].Value.ToString();
                        string coffee   = dgvOrder.Rows[i].Cells[1].Value.ToString();
                        string beanType = dgvOrder.Rows[i].Cells[2].Value.ToString();
                        string price    = dgvOrder.Rows[i].Cells[3].Value.ToString();
                        string quantity = dgvOrder.Rows[i].Cells[4].Value.ToString();
                        string subTotal = dgvOrder.Rows[i].Cells[5].Value.ToString();

                        data = "INSERT INTO [sales_detail]([ItemNo], [Coffee], [BeanType], [Price], [Quantity], [Total]) VALUES"
                             + " ('" + itemNo + "', '" + coffee + "', '" + beanType + "', '" + price + "', '" + quantity + "', '" + subTotal + "')";
                        DBHelper.DBHelper.ModifyRecord(data);

                        data = "UPDATE [stock] set [StockAmount] = [StockAmount]- '" + txtQuantity.Text + "'" + "WHERE [ItemCode] = '" + itemNo + "'";
                        DBHelper.DBHelper.ModifyRecord(data);
                        Stock_Load(sender, e);
                    }
                    MessageBox.Show("You Successfully purchased our item", "Purchase Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    string datesale = DateTime.Now.Date.ToString();
                    data = "INSERT INTO [sales_master]([OrderNumber], [CustomerName], [Date]) VALUES"
                                                 + " ('" + orderNo + "', '" + txtLoggedName.Text + "', '" + datesale + "')";
                    DBHelper.DBHelper.ModifyRecord(data);
                }
            }
            catch
            {
                MessageBox.Show("Enter cash payment", "Purchase Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(txtLoggedName.Text == "admin")
            {
                Stock s = new Stock();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You dont have permission to access stock", "Access Declined", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Century Gothic", 15);
            Brush brush = Brushes.Black;
            float lineHeight = font.GetHeight();

            // Set the starting position for printing
            float x = 200;
            float y = 10;

            // Print the header
            string header = "\t\tTop of the Morning Receipt\n" +
                            "============================================\r\n";
            graphics.DrawString(header, font, brush, x-100, y);

            y += 2 * lineHeight;
            string date = DateTime.Now.ToString();
            graphics.DrawString(date, font, brush, x, y);

            // Adjust the starting position for printing the details
            y += lineHeight * 2; // Add extra line spacing for the header

            // Iterate through each row in the DataGridView dgvOrder
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                // Get the values for each column in the current row
                string itemNo = row.Cells[0].Value.ToString();
                string coffee = row.Cells[1].Value.ToString();
                string beanType = row.Cells[2].Value.ToString();
                double price = Convert.ToDouble(row.Cells[3].Value);
                string quantity = row.Cells[4].Value.ToString();
                double subtotal = Convert.ToDouble(row.Cells[5].Value);

                // Print the details for the current row
                //y += lineHeight;
                graphics.DrawString("Item No:", font, brush, x, y);
                graphics.DrawString(itemNo, font, brush, x + 100, y);

                y += lineHeight;
                graphics.DrawString("Coffee:", font, brush, x, y);
                graphics.DrawString(coffee, font, brush, x + 100, y);

                y += lineHeight;
                graphics.DrawString("Bean Type:", font, brush, x, y);
                graphics.DrawString(beanType, font, brush, x + 100, y);

                y += lineHeight;
                graphics.DrawString("Price:", font, brush, x, y);
                graphics.DrawString(price.ToString(), font, brush, x + 100, y);

                y += lineHeight;
                graphics.DrawString("Quantity:", font, brush, x, y);
                graphics.DrawString(quantity, font, brush, x + 100, y);

                y += lineHeight;
                graphics.DrawString("Subtotal:", font, brush, x, y);
                graphics.DrawString(subtotal.ToString(), font, brush, x + 100, y);

                y += 2 * lineHeight; // Add extra line spacing between items
            }

            // Print the footer
            y += lineHeight;
            string line = "============================================\r\n";
            graphics.DrawString(line, font, brush, x - 100, y);
            y += lineHeight;
            //graphics.DrawString(line, font, brush, x + 100, y);
            graphics.DrawString("Total:", font, brush, x, y);
            graphics.DrawString(txtTotal.Text + "\t", font, brush, x + 100, y);


            y += lineHeight;
            graphics.DrawString("Cash:", font, brush, x, y);
            graphics.DrawString(txtCash.Text + "\t", font, brush, x + 100, y);

            y += lineHeight;
            graphics.DrawString("Change:", font, brush, x, y);
            graphics.DrawString(txtChange.Text + "\t", font, brush, x + 100, y);
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;

            previewDialog.ShowDialog();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && dgvOrder.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                dgvOrder.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}