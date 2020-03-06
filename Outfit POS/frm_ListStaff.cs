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
    public partial class frm_ListStaff : Form
    {


        public int staffID;

        public frm_ListStaff()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStaffs("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLConn.adding = true;
            SQLConn.updating = false;
            int init = 0;
            frm_AddEditStaff f2 = new frm_AddEditStaff(init);
            f2.ShowDialog();
        }


        public void LoadStaffs(string search)
        {
            try
            {
                SQLConn.sqL = "SELECT StaffID, CONCAT(Lastname, ', ', Firstname, ' ', MI) as ClientName, CONCAT(Street, ', ', Barangay, ', ', City , ', ', Province) as Address, ContactNo, username, role FROM Staff WHERE LASTNAME LIKE '" + search.Trim() + "%' ORDER By Lastname";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                ListView1.Items.Clear();

                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["StaffId"].ToString());
                    x.SubItems.Add(SQLConn.dr["ClientName"].ToString());
                    x.SubItems.Add(SQLConn.dr["ContactNo"].ToString());
                    x.SubItems.Add(SQLConn.dr["Address"].ToString());
                    x.SubItems.Add(SQLConn.dr["username"].ToString());
                    x.SubItems.Add(SQLConn.dr["Role"].ToString());

                    ListView1.Items.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                    staffID = Convert.ToInt32(ListView1.FocusedItem.Text);
                    frm_AddEditStaff f2 = new frm_AddEditStaff(staffID);
                    f2.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el registro para actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SQLConn.strSearch = InputBox.Show("Introduzca apellidpo del Staff", "Buscar Staff", " ").Text;
        
            if (SQLConn.strSearch.Length >= 1)
            {
                LoadStaffs(SQLConn.strSearch.Trim());
            }
            else if (string.IsNullOrEmpty(SQLConn.strSearch))
            {
                return;
            }
        }

        

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
