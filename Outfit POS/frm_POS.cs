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
    public partial class frm_POS : Form
    {
        string Username;
        int StaffID;
        string nInvoice;
        public frm_POS()
        {
            InitializeComponent();
        }
        private string get_Name() {
            

            try
            {
                SQLConn.sqL = "SELECT concat(`Lastname` ,', ', `Firstname`) as Nombre FROM staff where StaffID=" + StaffID.ToString();
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
               return SQLConn.cmd.ExecuteScalar().ToString();
                
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
            return null;
        }
        private string get_Role()
        {


            try
            {
                SQLConn.sqL = "SELECT Role FROM staff where StaffID=" + StaffID.ToString();
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                return SQLConn.cmd.ExecuteScalar().ToString();

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
            return null;
        }
        private string get_Invoice()
        {


            try
            {
                SQLConn.sqL = "SELECT max(`InvoiceNo`)+1 as invoice FROM `transactions`";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                return SQLConn.cmd.ExecuteScalar().ToString();

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
            return null;
        }
        public frm_POS(int _StaffID)
        {
            StaffID = _StaffID;
            Username = get_Name();
            nInvoice = get_Invoice();
            InitializeComponent();
            textBox8.Text = Username;
            textBox7.Text = get_Role();
            label9.Text = nInvoice;
           
        }
        private void get_product(string codigo, int operacion) {
            try
            {
                switch (operacion) { 
                    case 1:
                        
                    break;
                    case 2:
                        SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand from  product Barcode LIKE '" + codigo + "%' ";
                     break;
                    default:
                        SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand from  product ProductCode LIKE '" + codigo + "%' ";
                     break; 
                }
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
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
      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string ProductCode = textBox2.Text;

            }
        }
    }
}
