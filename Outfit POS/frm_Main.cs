using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            if (MessageBox.Show("¿Estas seguro que deseas salir ? ", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
             frm_POS lp = new frm_POS(StaffID);
             lp.ShowDialog();
           
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      private void button5_Click(object sender, EventArgs e)
        {
            frm_ReportFilterDailySales FR = new frm_ReportFilterDailySales();
            FR.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_ReportFilterStocks rf = new frm_ReportFilterStocks();
            rf.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frm_SystemSetting ss = new frm_SystemSetting();
            ss.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_ListReturns lr = new frm_ListReturns(StaffID);
            lr.ShowDialog();
        }
    }
}
