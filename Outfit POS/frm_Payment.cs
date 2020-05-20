using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Outfit_POS
{
    public partial class frm_Payment : Form
    {
        string InvoiceNo;
        double TotalAmount;
        public frm_Payment(string invoiceNo, double totalAmount)
        {
            InitializeComponent();
            InvoiceNo = invoiceNo;
            TotalAmount = totalAmount;
        }

        private void AddPayment()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO PAYMENT(InvoiceNo, Cash, PChange) VALUES('" + InvoiceNo + "', '" + txtCash.Text.Replace(",", "") + "', '" + txtChange.Text.Replace(",", "") + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void frmPayment_Load(System.Object sender, System.EventArgs e)
        {
            this.Location = new Point(515, 470);
            txtTA.Text = TotalAmount.ToString();
            txtCash.Text = "";
        }

        private void txtCash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == ControlChars.Cr)
            {
                double ta= 99999999, cash = 99999999, chan = 99999999;
                double.TryParse(txtTA.Text.Replace(",", ""), out ta);
                double.TryParse(txtCash.Text.Replace(",", ""), out cash);
                chan = Math.Round(TotalAmount - cash,2);
                if ( cash == 99999999)
                    MessageBox.Show("ERROR: en datos", "Atencion");
                else
                if (chan > 0)
                {
                    Interaction.MsgBox("Insuficient cash to paid the total amount", MsgBoxStyle.Exclamation, "payment");
                    txtCash.Focus();
                }
                else
                {
                    AddPayment();
                    if (System.Windows.Forms.Application.OpenForms["frmPOS"] != null)
                    {
                        // frmPOS p =  (System.Windows.Forms.Application.OpenForms["frmPOS"] as frmPOS);
                        //p.AddTransaction();
                        //p.AddTransactionDetails();
                        //p.UpdateProductQuantity();

                          //frm_PrintReceipt pr = new frm_PrintReceipt(InvoiceNo);
                        //  pr.Show();

                        Interaction.MsgBox("Transaction completed. Press OK for a new transaction.", MsgBoxStyle.Information, "Transaction");
                        //p.NewTransaction();
                    }

                   
                    // My.MyProject.Forms.frmPrintReceipt.Show();
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
            }
        }


        private void frmPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            this.Location = new Point(515, 470);
            txtTA.Text = TotalAmount.ToString();// Strings.FormatNumber(TotalAmount);
            txtCash.Text = "";
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            txtChange.Text = Strings.Format(Conversion.Val(txtCash.Text.Replace(",", "")) - Conversion.Val(txtTA.Text.Replace(",", "")));
        }
    }
}
