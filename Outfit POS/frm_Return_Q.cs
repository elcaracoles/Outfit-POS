
using MySql.Data.MySqlClient;
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
    public partial class frm_Return_Q : Form
    {
        string InvoiceNo { get; set; }
        double Quantity { get; set; }
        public double ret { get; set; }
        public frm_Return_Q(string _invoiceNo, double _Quantity)
        {
            InitializeComponent();
            InvoiceNo = _invoiceNo;
            Quantity = _Quantity;
        }
     

        private void frmPayment_Load(System.Object sender, System.EventArgs e)
        {
            this.Location = new Point(515, 470);
            txtQV.Text = Quantity.ToString();
            txtQD.Text = "";
        }

        private void txtCash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                   // AddPayment();
                   
                   
                    this.DialogResult = DialogResult.OK;
                    
               
            }
        }


        private void frmPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            this.Location = new Point(515, 470);
            txtQV.Text = Quantity.ToString();// Strings.FormatNumber(TotalAmount);
            txtQD.Text = "";
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            double Qret = 99999999;
            double.TryParse(txtQD.Text.Replace(",", ""), out Qret);
            if (Qret == 99999999)
                MessageBox.Show("ERROR: Introduccion en datos", "Atencion");
            else
            {
                ret = Math.Round(Quantity - Qret, 2);
                if (ret < 0)
                    txtQD.Text = "";
            }
            //txtR.Text = Strings.Format(Conversion.Val(txtQD.Text.Replace(",", "")) - Conversion.Val(txtQV.Text.Replace(",", "")));
        }
    }
}
