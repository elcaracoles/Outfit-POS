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
    public partial class frm_ListCategory : Form
    {
        public int catgoryID;

        public frm_ListCategory()
        {
            InitializeComponent();
        }

        public void LoadCategories(string strSearch)
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM CATEGORY WHERE CategoryName LIKE '" + strSearch + "%' ORDER By CategoryName";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader(CommandBehavior.CloseConnection);

                ListViewItem x = null;
                ListView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["CategoryNo"].ToString());
                    x.SubItems.Add(SQLConn.dr["CategoryName"].ToString());
                    x.SubItems.Add(SQLConn.dr["Description"].ToString());
                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
               // SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SQLConn.adding = true;
            SQLConn.updating = false;
            int init = 0;
            frm_AddEditCategory aeC = new frm_AddEditCategory(init);
            aeC.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show("Por favor seleccione el registro para actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(ListView1.FocusedItem.Text))
                {

                }
                else
                {
                    SQLConn.adding = false;
                    SQLConn.updating = true;
                    catgoryID = Convert.ToInt32(ListView1.FocusedItem.Text);
                    frm_AddEditCategory aeC = new frm_AddEditCategory(catgoryID);
                    aeC.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el registro para actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLConn.strSearch = InputBox.Show("ENTER PRODUCT NAME.", "Search Product", " ").Text;

            if (SQLConn.strSearch.Length >= 1)
            {
                LoadCategories(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListCategory_Load(object sender, EventArgs e)
        {
            LoadCategories("");
        }

       

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
