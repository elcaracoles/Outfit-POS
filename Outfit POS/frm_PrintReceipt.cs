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
    public partial class frm_PrintReceipt : Form
    {
        string InvoiceNo { get; set; }
        public frm_PrintReceipt( string _InvoiceNo)
        {
            InitializeComponent();
            InvoiceNo = _InvoiceNo;
        }
        private void LoadItemstoDatagrid()
        {
            int y=0;
            try
            {
                SQLConn.sqL  = "Select SUM(Quantity) as TotalQuantity, Description, ItemPrice, (ItemPrice * SUM(Quantity)) as Amount FROM Product as P, TransactionDetails as TD WHERE TD.ProductNo = P.ProductNo AND InvoiceNo ='"+InvoiceNo+"' GROUP BY TD.ProductNo";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                dgw.Rows.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    dgw.Rows.Add(SQLConn.dr["TotalQuantity"].ToString(), SQLConn.dr["Description"].ToString(), SQLConn.dr["ItemPrice"].ToString(), SQLConn.dr["Amount"].ToString());
                    dgw.Height += 19;
                    y += 19;
                }

                Panel2.Location = new Point(9, 187 + y);
                Panel1.Height += y;
                this.Height += y;
                dgw.Height -= 20;
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
        public void GetCompanyInfo()
        {
            try
            {
                SQLConn.sqL = "SELECT Name, Address, PhoneNo,  TINNumber FROM Company";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();


                if (SQLConn.dr.Read())
                {
                    CompanyName.Text = SQLConn.dr[0].ToString();
                    CompanyAddress.Text = SQLConn.dr[1].ToString();
                    CompanyPhoneNo.Text = "Telefono:"+SQLConn.dr[2].ToString();
                    CompanyTINNumber.Text = "CIF:"+SQLConn.dr[3].ToString();
                }
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

        private void LoadReceiptInfo()
        {
            try
            {
                GetCompanyInfo();
                SQLConn.sqL = "SELECT T.InvoiceNo, CONCAT(Lastname,', ', Firstname, ' ', MI, '.') as StaffName, Quantity, Description, ItemPrice, (ItemPRice * Quantity) as ItemAmount, VatAmount, NonVatTotal, TotalAmount, Cash, PChange FROM Product as P, TransactionDetails as TD, Transactions as T, Staff as S, Payment as Pay WHERE P.ProductNo = TD.ProductNo AND TD.InvoiceNo = T.InvoiceNo AND S.StaffID = T.StaffID AND Pay.InvoiceNo = T.InvoiceNO AND T.InvoiceNo = '"+InvoiceNo+"'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblInvoice.Text = SQLConn.dr["InvoiceNo"].ToString();
                    lblEmpName.Text = SQLConn.dr["StaffName"].ToString();
                    lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
                    lblVat.Text = (SQLConn.dr["VatAmount"].ToString());
                    lblSubtotal.Text = (SQLConn.dr["NonVatTotal"].ToString());
                    lblTotal.Text = (SQLConn.dr["TotalAmount"].ToString());
                    lblCash.Text = (SQLConn.dr["Cash"].ToString());
                    lblChange.Text = (SQLConn.dr["PChange"].ToString());
                    LoadItemstoDatagrid();
                }
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

        private void frmPrintReceipt_Load(System.Object sender, System.EventArgs e)
        {
            LoadReceiptInfo();
            //PrintDocument1.Print();
            //this.Close();
        }

        private void PrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Panel1.Width, this.Panel1.Height);
            Panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.Panel1.Width, this.Panel1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            PageSetupDialog aPS = new PageSetupDialog();
            aPS.Document = PrintDocument1;
        }
    }
}
