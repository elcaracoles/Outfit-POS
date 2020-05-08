using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Outfit_POS
{
    public partial class frm_FindProduct : Form
    {
        public int productID { get; set; }
        public frm_FindProduct()
        {
            InitializeComponent();
        }
        public void LoadProducts(string strSearch)
        {
            try
            {
                SQLConn.sqL = "SELECT ProductNo, ProductCOde, P.Description, Barcode, UnitPrice, StocksOnHand, ReorderLevel, CategoryName FROM Product as P LEFT JOIN Category C ON P.CategoryNo = C.CategoryNo WHERE P.Description LIKE '" + strSearch + "%' ORDER BY Description";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView1.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["ProductNo"].ToString());
                    x.SubItems.Add(SQLConn.dr["ProductCode"].ToString());
                    x.SubItems.Add(SQLConn.dr["Description"].ToString());
                    x.SubItems.Add(SQLConn.dr["Barcode"].ToString());
                    x.SubItems.Add(SQLConn.dr["CategoryName"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["UnitPrice"], "#,##0.00"));
                    x.SubItems.Add(SQLConn.dr["StocksOnHand"].ToString());
                    x.SubItems.Add(SQLConn.dr["ReOrderLevel"].ToString());

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

        private void frm_FindProduct_Load(object sender, EventArgs e)
        {
            LoadProducts("");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLConn.strSearch = InputBox.Show("ENTER PRODUCT NAME.", "Search Product", " ").Text;

            if (SQLConn.strSearch.Length >= 1)
            {
                LoadProducts(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        private void btnStocksIn_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                Interaction.MsgBox("Please select record to add stock", MsgBoxStyle.Exclamation, "StocksIn");
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(ListView1.FocusedItem.Text))
                {

                }
                else
                {

                    productID = Convert.ToInt32(ListView1.FocusedItem.Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to add stock", MsgBoxStyle.Exclamation, "StocksIn");
                return;
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
           
            try
            {
                if (string.IsNullOrEmpty(ListView1.SelectedItems[0].SubItems[0].Text))
                {

                }
                else
                {

                    productID = Convert.ToInt32(ListView1.SelectedItems[0].SubItems[0].Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to add stock", MsgBoxStyle.Exclamation, "StocksIn");
                return;
            }
        }
    }
}
