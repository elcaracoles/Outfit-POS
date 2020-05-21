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
    public partial class frm_ListReturns : Form
    {
        int StaffID { get; set; }
        public frm_ListReturns(int _StaffID)
        {
            InitializeComponent();
            StaffID = _StaffID;
            dtStartDate.Value = DateTime.Now.AddDays(-7);
        }
        public void SalesReturns(DateTime startDate, DateTime endDate, string searchString)
        {

            try
            {
                endDate = endDate.AddDays(1);
                SQLConn.sqL = "SELECT SalesReturnId, ReturnDate, sr.InvoiceNo, CONCAT(lastname, ', ', firstname, ' ', MI) as StaffName, TotalAmount, SUM(sri.Quantity) as TotalQuantity FROM SalesReturn sr INNER JOIN SalesReturnItem sri ON sr.InvoiceNo = sri.InvoiceNo INNER JOIN Staff s ON s.StaffId = sr.userID WHERE ReturnDate  BETWEEN '" + startDate.ToString("yyyy-MM-dd") + "' AND '" + endDate.ToString("yyyy-MM-dd") + "' AND sr.InvoiceNo LIKE '%" + txtName.Text + "%' GROUP BY sr.InvoiceNo ORDER BY ReturnDate, sr.InvoiceNo DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["SalesReturnId"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["ReturnDate"], "MM/dd/yyyy"));
                    x.SubItems.Add(SQLConn.dr["InvoiceNo"].ToString());
                    x.SubItems.Add(SQLConn.dr["StaffName"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["TotalAmount"], "#,##0.00"));
                    x.SubItems.Add(SQLConn.dr["TotalQuantity"].ToString());
                    //Strings.Format(SQLConn.dr["TotalAmount"], "#,##0.00")
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

            try
            {
                SQLConn.sqL = "SELECT ProductCode, Description, Quantity, UnitPrice, (Quantity * UnitPrice) ExtendedPrice FROM SalesReturnItem sri INNER JOIN Product p ON p.ProductNo = sri.ProductID WHERE Sri.InvoiceNo = '" + invoiceNo + "' ORDER BY Description ";
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
                    x.SubItems.Add(Strings.Format(SQLConn.dr["UnitPrice"], "#,##0.00"));
                    x.SubItems.Add(Strings.Format(SQLConn.dr["ExtendedPrice"], "#,##0.00"));
                    //Strings.Format(SQLConn.dr["ExtendedPrice"], "#,##0.00")
                    ListView2.Items.Add(x);
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

        private void frm_ListReturns_Load(object sender, EventArgs e)
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

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReturnItems(ListView1.FocusedItem.SubItems[2].Text);
            }
            catch
            {

            }
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            frm_Return pr = new frm_Return(  StaffID);//label9.Text);
            pr.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
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
                    frm_PrintReturn pr = new frm_PrintReturn(item.SubItems[2].Text);//label9.Text);
                    pr.ShowDialog();
                   
                }
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el registro para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
         

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SalesReturns(dtStartDate.Value, dtEndDate.Value, txtName.Text);
        }
    }
}
