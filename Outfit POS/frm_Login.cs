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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            SQLConn.getData();

        }

        private void Login()
        {
            try
            {
                SQLConn.sqL = "SELECT * FROM Staff WHERE Username = '" + txt_user.Text + "' AND UPassword = '" + txt_Pass.Text + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {

                    if (SQLConn.dr["Role"].ToString().ToUpper() == "ADMIN")
                    {
                        frm_Main m = new frm_Main(SQLConn.dr["Username"].ToString(), Convert.ToInt32(SQLConn.dr["StaffID"]));
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        // frmPOS m = new frmPOS(Convert.ToInt32(SQLConn.dr["StaffID"]));
                        //  m.Show();
                        this.Hide();
                    }
                }
                else
                {
                    Interaction.MsgBox("Invalid Password. Please try again.", MsgBoxStyle.Exclamation, "Login");
                }

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                frm_DatabaseConfig dc = new frm_DatabaseConfig();
                dc.ShowDialog();
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
