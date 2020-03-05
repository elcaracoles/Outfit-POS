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

namespace Outfit_POS
{
    public partial class frm_Main : Form
    {
        string Username;
        int StaffID;
        public frm_Main(string username, int staffID)
        {
            InitializeComponent();

            Username = username;
            StaffID = staffID;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SQLConn.getData();
            this.lbluser.Text = "Login user : " + Username.ToUpper();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit System") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ListStaff f1 = new frm_ListStaff();
            f1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "Date-Time : " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_DatabaseConfig db = new frm_DatabaseConfig();
            db.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ListCategory lc = new frm_ListCategory();
            lc.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit System") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ListProduct lp = new frm_ListProduct();
            lp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // frmPOS lp = new frmPOS(StaffID);
            // lp.ShowDialog();
            Interaction.MsgBox("Message us on our facebook page. https://www.facebook.com/CyberVSS");
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      private void button5_Click(object sender, EventArgs e)
        {
            /*/frmReportFilterDailySales FR = new frmReportFilterDailySales();
            FR.ShowDialog();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* frmReportFilterStocks rf = new frmReportFilterStocks();
            rf.ShowDialog();*/
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frm_SystemSetting ss = new frm_SystemSetting();
            ss.ShowDialog();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
