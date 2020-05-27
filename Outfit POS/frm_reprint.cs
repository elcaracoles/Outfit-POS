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
using Microsoft.VisualBasic;

namespace Outfit_POS
{
    public partial class frm_reprint : Form
    {
        public frm_reprint()
        {
            InitializeComponent();
            invoice = "";
           
            moneyBak = 0;
            dtStartDate.Value = DateTime.Now.AddDays(-15);
        }
        
        string invoice { get; set; }
        int StaffID { get; set; }
        double moneyBak { get; set; }
       

        public void SalesReturns(DateTime startDate, DateTime endDate, string searchString)
        {

            try
            {
                endDate = endDate.AddDays(1);
                SQLConn.sqL = "SELECT T.InvoiceNo, Tdate, CONCAT(Lastname,', ', Firstname, ' ', MI, '.') as StaffName, TotalAmount,   SUM(Quantity) as TotalQuantity, VatAmount ,NonVatTotal FROM Product as P, TransactionDetails as TD, Transactions as T, Staff as S, Payment as Pay WHERE P.ProductNo = TD.ProductNo AND TD.InvoiceNo = T.InvoiceNo AND S.StaffID = T.StaffID AND Pay.InvoiceNo = T.InvoiceNO and Tdate  BETWEEN '" +
                    startDate.ToString("MM/dd/yyyy") + "' AND '" + endDate.ToString("MM/dd/yyyy") + "' AND T.InvoiceNo LIKE '%" + txtName.Text + "%' GROUP BY T.InvoiceNo ORDER BY TDate, T.InvoiceNo DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["Tdate"].ToString());
                    x.SubItems.Add(SQLConn.dr["InvoiceNo"].ToString());

                    x.SubItems.Add(SQLConn.dr["StaffName"].ToString());
                    x.SubItems.Add(SQLConn.dr["VatAmount"].ToString());
                    x.SubItems.Add(SQLConn.dr["NonVatTotal"].ToString());
                    x.SubItems.Add(SQLConn.dr["TotalAmount"].ToString());
                    x.SubItems.Add(SQLConn.dr["TotalQuantity"].ToString());
                    //Strings.Format(SQLConn.dr["TotalAmount"], "#,##0.00")  VatAmount ,NonVatTotal
                    ListView1.Items.Add(x);
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

        public void LoadReturnItems(string invoiceNo)
        {
            invoice = invoiceNo;
            try
            {
                //  SQLConn.sqL = "SELECT ProductCode, Description, Quantity, UnitPrice, (Quantity * UnitPrice) ExtendedPrice FROM SalesReturnItem sri INNER JOIN Product p ON p.ProductNo = sri.ProductID WHERE Sri.InvoiceNo = '" + invoiceNo + "' ORDER BY Description ";
                SQLConn.sqL = "select p.ProductNo as ProductCode, Description, TD.Quantity - COALESCE(rt.Quantity, 0) as Quantity,ItemPrice, (ItemPRice * (TD.Quantity - COALESCE(rt.Quantity, 0)) ) as ItemAmount , COALESCE(rt.Quantity, 0) as Dev FROM Product as P inner join  TransactionDetails as TD on P.ProductNo = TD.ProductNo inner join Transactions as T on TD.InvoiceNo = T.InvoiceNo inner join Staff as S on S.StaffID = T.StaffID inner join Payment as Pay on Pay.InvoiceNo = T.InvoiceNO left join salesreturnitem as rt on rt.InvoiceNo = T.InvoiceNo and rt.ProductID = TD.ProductNo where T.InvoiceNo = '" + invoiceNo + "' ORDER BY Description ";

                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView2.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["ProductCode"].ToString());
                    x.SubItems.Add(SQLConn.dr["Description"].ToString());
                    x.SubItems.Add(SQLConn.dr["Quantity"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["ItemPrice"], "#,##0.00"));
                    x.SubItems.Add(Strings.Format(SQLConn.dr["ItemAmount"], "#,##0.00"));
                    x.SubItems.Add(Strings.Format(SQLConn.dr["Dev"], "#,##0.00"));
                    //Strings.Format(SQLConn.dr["ExtendedPrice"], "#,##0.00")
                    ListView2.Items.Add(x);
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

        private void frm_Returns_Load(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
        }
        private void ListView1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReturnItems(ListView1.FocusedItem.SubItems[1].Text);
            }
            catch
            {

            }
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }
        private void AddSalesreturn()
        {
            string InvoiceNo, SubTotalAmount, VatAmount, TotalAmount;

            InvoiceNo = ListView1.FocusedItem.SubItems[1].Text;
            VatAmount = ListView1.FocusedItem.SubItems[3].Text;
            SubTotalAmount = ListView1.FocusedItem.SubItems[4].Text;
            TotalAmount = ListView1.FocusedItem.SubItems[5].Text;

            try
            {
                SQLConn.ConnDB();
                SQLConn.cmd.Connection = SQLConn.conn;
                SQLConn.cmd.CommandText = "SELECT COUNT(*) FROM salesreturn where InvoiceNo=" + InvoiceNo;
                //string result = cConvert.ToInt32(SQLConn.cmd.ExecuteScalar());// .ToString();
                Int32 count = Convert.ToInt32(SQLConn.cmd.ExecuteScalar());// (Int32)SQLConn.cmd.ExecuteScalar();NOW(),time(Now())
                if (count == 0)
                    SQLConn.sqL = "insert into salesreturn (InvoiceNo, VatAmount, SubTotalAmount, TotalAmount, UserID, ReturnDate) values (" +
                        InvoiceNo + "," + VatAmount + "," + SubTotalAmount + "," + moneyBak + "," + StaffID.ToString() + ",NOW())";
                else

                    SQLConn.sqL = "update salesreturn set  InvoiceNo=" + InvoiceNo + ", VatAmount=" + VatAmount + ", SubTotalAmount=" + SubTotalAmount + ", TotalAmount=" + moneyBak + ", UserID=" + StaffID.ToString() + ", ReturnDate =NOW() where InvoiceNo=" + InvoiceNo;


                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
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
        private void AddSalesreturnitem()
        {
            string InvoiceNo, ProductNo, ItemPrice, Quantity, Extended, returned;
            try
            {
                foreach (ListViewItem item in ListView2.Items)//recorres la lista
                {
                    InvoiceNo = ListView1.FocusedItem.SubItems[1].Text;
                    ProductNo = item.SubItems[0].Text;
                    ItemPrice = item.SubItems[3].Text;
                    Quantity = item.SubItems[2].Text.Replace(',', '.');
                    Extended = item.SubItems[4].Text;
                    returned = item.SubItems[5].Text.Replace(',', '.');
                    if (Quantity.Trim() != "0")
                    {
                        SQLConn.ConnDB();
                        SQLConn.cmd.Connection = SQLConn.conn;
                        SQLConn.cmd.CommandText = "SELECT COUNT(*) FROM salesreturnitem where InvoiceNo='" + InvoiceNo + "' and ProductID=" + ProductNo;
                        Int32 count = Convert.ToInt32(SQLConn.cmd.ExecuteScalar());
                        if (count == 0)
                            SQLConn.sqL = "insert into salesreturnitem  (InvoiceNo,ProductID,Quantity) values ('" + InvoiceNo + "'," + ProductNo + "," + returned + ")";

                        else
                            SQLConn.sqL = "update salesreturnitem  set  Quantity=" + returned + " where InvoiceNo='" + InvoiceNo + "' and ProductID=" + ProductNo;



                        // SQLConn.ConnDB();
                        SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                        SQLConn.cmd.ExecuteNonQuery();
                    }


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
        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show("Por favor seleccione el registro para Imprimir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (ListView1.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione el registro para Imprimir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                ListView.SelectedListViewItemCollection selected = ListView1.SelectedItems;//cargas la coleccion de los items seleccionados
                foreach (ListViewItem item in selected)//recorres la lista
                {
                    // ListView1.Items.Remove(item);//eliminas los item del listview
                    frm_PrintReceipt pr = new frm_PrintReceipt(item.SubItems[2].Text);//label9.Text);
                    pr.ShowDialog();

                }
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el registro para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
