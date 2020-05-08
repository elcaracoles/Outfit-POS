using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outfit_POS
{
    public partial class frm_Discount : Form
    {
        public double discount { get; set; }
        public frm_Discount()
        {
            InitializeComponent();
        }

        private void btnStocksIn_Click(object sender, EventArgs e)
        {
            double tmp = 0;
           double.TryParse( txtTA.Text, out tmp);
            discount = tmp;
            this.DialogResult = DialogResult.OK;
        }

        private void txtTA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double tmp = 0;
                double.TryParse(txtTA.Text, out tmp);
                discount = tmp;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
