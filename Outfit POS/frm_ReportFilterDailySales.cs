using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Outfit_POS
{
    public partial class frm_ReportFilterDailySales : Form
    {
        public frm_ReportFilterDailySales()
        {
            InitializeComponent();
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                rbInvoice.Checked = false;
            }
        }

        private void rbInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInvoice.Checked == true)
            {
                rbUser.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((rbUser.Checked == false) && (rbInvoice.Checked == false))
            {
                Interaction.MsgBox("Please select report by User or Invoice No", MsgBoxStyle.Information, "Select Report");
                return;
            }


            if (rbUser.Checked == true)
            {
                Interaction.MsgBox("Message us on our facebook page. https://www.facebook.com/CyberVSS");
            }
            else
            {
                frm_ReportDailSalesByInvoice R = new frm_ReportDailSalesByInvoice(DateTimePicker1.Value);
                R.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
