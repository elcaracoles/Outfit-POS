using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Outfit_POS
{
    public partial class frm_PrintReturn : Form
    {
        string InvoiceNo { get; set; }
        public frm_PrintReturn(string _InvoiceNo)
        {
            InitializeComponent();
            InvoiceNo = _InvoiceNo;
        }
        private void LoadItemstoDatagrid()
        {
            int y = 0;
            try
            {
               // SQLConn.sqL = "Select SUM(Quantity) as TotalQuantity, Description, ItemPrice, (ItemPrice * SUM(Quantity)) as Amount FROM Product as P, TransactionDetails as TD WHERE TD.ProductNo = P.ProductNo AND InvoiceNo ='" + InvoiceNo + "' GROUP BY TD.ProductNo";
                SQLConn.sqL = @"SELECT SUM(Quantity) as TotalQuantity,Description, UnitPrice ,   UnitPrice, (Quantity * UnitPrice) ExtendedPrice FROM SalesReturnItem sri INNER JOIN Product p ON p.ProductNo = sri.ProductID WHERE Sri.InvoiceNo = '" + InvoiceNo + "' GROUP BY ProductCode ";

                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                dgw.Rows.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    dgw.Rows.Add(SQLConn.dr["TotalQuantity"].ToString(), SQLConn.dr["Description"].ToString(), SQLConn.dr["UnitPrice"].ToString(), SQLConn.dr["ExtendedPrice"].ToString());
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
                MessageBox.Show(ex.ToString());
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
                    CompanyPhoneNo.Text = "Telefono:" + SQLConn.dr[2].ToString();
                    CompanyTINNumber.Text = "CIF:" + SQLConn.dr[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                SQLConn.sqL = "SELECT sr.InvoiceNo, CONCAT(lastname, ', ', firstname, ' ', MI) as StaffName, Quantity, Description, UnitPrice, (Quantity * UnitPrice) ExtendedPrice, VatAmount, SubTotalAmount,TotalAmount,SalesReturnId, ReturnDate FROM SalesReturn sr INNER JOIN SalesReturnItem sri ON sr.InvoiceNo = sri.InvoiceNo INNER JOIN Staff s ON s.StaffId = sr.userID INNER JOIN Product p ON p.ProductNo = sri.ProductID  where sr.InvoiceNo = '" + InvoiceNo + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                

                if (SQLConn.dr.Read() == true)
                {
                   // DateTime a = DateTime.ParseExact(SQLConn.dr["ReturnDate"].ToString(), "mm/dd/yyyy", culture);
                    lblInvoice.Text = SQLConn.dr["InvoiceNo"].ToString();
                    lblEmpName.Text = SQLConn.dr["StaffName"].ToString();
                    lblDate.Text = SQLConn.dr["ReturnDate"].ToString();
                    lblReturn.Text = (SQLConn.dr["SalesReturnId"].ToString());
                    // lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
                    lblVat.Text = (SQLConn.dr["VatAmount"].ToString());
                    lblSubtotal.Text = (SQLConn.dr["SubTotalAmount"].ToString());
                    lblTotal.Text = (SQLConn.dr["TotalAmount"].ToString());
                   // lblCash.Text = (SQLConn.dr["Cash"].ToString());
                    //lblChange.Text = (SQLConn.dr["PChange"].ToString());
                    LoadItemstoDatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void frm_PrintReturn_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
