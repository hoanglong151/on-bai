using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            this.btnCompute.Click +=new System.EventHandler(this.btnCompute_Click);
            string inValue;
            double purchaseAmt, percent, ans;
            inValue = txtPurchase.Text;
            purchaseAmt = double.Parse(inValue);
            inValue = label5.Text; 
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;
            percent = (double.Parse(label5.Text.Remove(label5.Text.Length - 1, 1))) / 100;
            ans = (purchaseAmt * percent) + purchaseAmt;
            txtTotalDue.Text = String.Format("{0:C}", ans).ToString();
        }

    }
}
