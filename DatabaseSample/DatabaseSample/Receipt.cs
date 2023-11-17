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
    public partial class Receipt : Form
    {
        public string data = "";
        public Receipt()
        {
            InitializeComponent();
        }
        public void setReceipt(string receiptItemNo, string receiptCoffee, string receiptBeanType, string receiptPrice, string receiptQuantity, 
                               string receiptSubTotal, string totalReceipt, string cashReceipt, string changeReceipt)
        {
            lblItemNoReceipt.Text = receiptItemNo;
            lblCoffeeReceipt.Text = receiptCoffee;
            lblBeanTypeReceipt.Text = receiptBeanType;
            lblPriceReceipt.Text = receiptPrice;
            lblQuantityReceipt.Text = receiptQuantity;
            lblSubtotalReceipt.Text = receiptSubTotal;
            lblTotalReceipt.Text = totalReceipt;
            lblCashReceipt.Text = cashReceipt;
            lblChangeReceipt.Text = changeReceipt;
        }
        private void Receipt_Load(object sender, EventArgs e)
        {
        }
    }
}
