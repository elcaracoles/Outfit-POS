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
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            ListViewItem x = null;
            x = new ListViewItem((listView1.Items.Count +1).ToString());
            x.SubItems.Add(label18.Text);
            x.SubItems.Add(textBox3.Text);
            x.SubItems.Add(textBox4.Text);
            x.SubItems.Add(textBox5.Text);
            x.SubItems.Add(textBox6.Text);
            x.SubItems.Add("0");
            
            listView1.Items.Add(x);
            textBox12.Text = total_e().ToString();
            textBox10.Text = total_p().ToString();
            ch_texbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Por favor seleccione el registro para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (listView1.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Por favor seleccione el registro para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                ListView.SelectedListViewItemCollection selected = listView1.SelectedItems;//cargas la coleccion de los items seleccionados
                foreach (ListViewItem item in selected)//recorres la lista
                {
                    listView1.Items.Remove(item);//eliminas los item del listview
                }
            }
            catch
            {
                MessageBox.Show("Por favor seleccione el registro para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            textBox12.Text = total_e().ToString();
            textBox10.Text = total_p().ToString();
            textBox1.Focus();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
               
                product pr = new product(textBox2.Text, 1);
                fill_Product(pr);
               
                ch_texbox();
            }
        }
        private void ch_texbox() {
            if (textBox2.Enabled == true && textBox1.Enabled == true && textBox5.ReadOnly == true)
            {

               
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                
                textBox5.ReadOnly = false;
                textBox5.Focus();
            }
            else {
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                textBox5.ReadOnly = true ;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "1";
                textBox1.Focus();

            }
        }

        private void fill_Product(product pr) {
            if (pr.StocksOnHand > 0) { 
            textBox1.Text = pr.Barcode;
            textBox2.Text = pr.ProductCode;
            textBox3.Text = pr.Description;
            textBox4.Text = pr.UnitPrice.ToString();
            label18.Text = pr.ProductNo.ToString();
            }
            else
            {
                MessageBox.Show("No hay Stock suficiente de "+pr.Description,"Alerta!");
                ch_texbox();
            }

        }
        private double total_e()
        {
            double total = 0;
            foreach (ListViewItem lstItem in listView1.Items) // listView has ListViewItem objects
            {
                total += double.Parse(lstItem.SubItems[5].Text); // Columns 4
            }
            return total;
        }
        private double total_p()
        {
            double total = 0;
            foreach (ListViewItem lstItem in listView1.Items) // listView has ListViewItem objects
            {
                total += double.Parse(lstItem.SubItems[4].Text); // Columns 4
            }
            return total;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                product pr = new product(textBox1.Text, 2);
                fill_Product(pr);

                ch_texbox();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double precioU = 0;
                int Cantidad = 0;
                double total = 0;
               
                double.TryParse(textBox4.Text,out precioU);
                int.TryParse(textBox5.Text, out Cantidad);
                total = precioU * Cantidad;
                textBox6.Text = total.ToString();
                button1.Focus();
                // ch_texbox();
            }
        }
        private void fill_listview() {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string InvoiceNo,ProductNo, ItemPrice, Quantity, Discount, NonVatTotal, VatAmount, TotalAmount;
            InvoiceNo = label9.Text;
            NonVatTotal = textBox9.Text;
            VatAmount = textBox11.Text;
            TotalAmount = textBox12.Text;
            try
            {
                SQLConn.sqL = "insert into transactions (InvoiceNo,TDate,TTime,NonVatTotal,VatAmount,TotalAmount,StaffID) values (" + InvoiceNo + ",date(Now()),time(Now())," + NonVatTotal + "," + VatAmount + "," + TotalAmount + "," + StaffID.ToString() + ")";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                foreach (ListViewItem item in listView1.Items)//recorres la lista
                {
                   
                    ProductNo = item.SubItems[1].Text;
                    ItemPrice = item.SubItems[3].Text;
                    Quantity = item.SubItems[4].Text;
                    Discount = item.SubItems[6].Text;
                    

                    SQLConn.sqL = "insert into transactiondetails (InvoiceNo,ProductNo,ItemPrice,Quantity,Discount) values (" + InvoiceNo + "," + ProductNo + "," + ItemPrice + "," + Quantity + "," + Discount + ")";
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.cmd.ExecuteNonQuery();

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally {
                limpiar();
            }

        }
        private void limpiar() {
            listView1.Items.Clear();
            label9.Text = get_Invoice();
            textBox3.Text = "";
            textBox4.Text = "0.00";
            textBox5.Text = "1";
            textBox6.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";

            textBox1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_FindProduct fndProduct = new frm_FindProduct();
                       
            if (fndProduct.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.textBox2.Text = fndProduct.productID.ToString();
                product pr = new product(textBox2.Text, 1);
                fill_Product(pr);

                ch_texbox();

            }
            else
            {
                this.textBox2.Text = "";
            }
            fndProduct.Dispose();
        }
    }
    class product {
        #region prop product
        private int _ProductNo=0;
        private string _ProductCode="";
        private string _Description="";
        private string _Barcode="";
        private double _UnitPrice=0;
        private double _StocksOnHand=0;
        private int _ReorderLevel=0;
        private int _CategoryNo=0;
        #endregion
        #region getset_product
        public int ProductNo
        {
            get
            {
                return _ProductNo;
            }
            set
            {
                _ProductNo = value;
            }
        }
        public string ProductCode
        {
            get
            {
                return _ProductCode;
            }
            set
            {
                _ProductCode = value;
            }
        }
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        public string Barcode
        {
            get
            {
                return _Barcode;
            }
            set
            {
                _Barcode = value;
            }
        }
        public double UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                _UnitPrice = value;
            }
        }
        public double StocksOnHand
        {
            get
            {
                return _StocksOnHand;
            }
            set
            {
                _StocksOnHand = value;
            }
        }
        public int CategoryNo
        {
            get
            {
                return _CategoryNo;
            }
            set
            {
                _CategoryNo = value;
            }
        }
        public int ReorderLevel
        {
            get
            {
                return _ReorderLevel;
            }
            set
            {
                _ReorderLevel = value;
            }
        }
        #endregion
        public  product(string codigo, int operacion)
        {
            try
            {
                switch (operacion)
                {
                    case 1:
                        SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand, ReorderLevel, CategoryNo from  product where ProductNo = " + codigo + " limit 1";
                        break;
                    case 2:
                        SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand ,ReorderLevel,CategoryNo from  product where Barcode LIKE '" + codigo + "' limit 1";
                        break;
                    default:
                        SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand, ReorderLevel, CategoryNo from  product where ProductNo = " + codigo + " limit 1";
                        // SQLConn.sqL = "select ProductNo,ProductCode, Description,Barcode,UnitPrice, StocksOnHand, ReorderLevel, CategoryNo from  product where ProductCode LIKE '" + codigo + "' limit 1";
                        break;
                }
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                while (SQLConn.dr.Read() == true)
                {
                   Int32.TryParse (SQLConn.dr["ProductNo"].ToString(), out _ProductNo);
                   _ProductCode = SQLConn.dr["ProductCode"].ToString();
                   _Description = SQLConn.dr["Description"].ToString();
                   _Barcode = SQLConn.dr["Barcode"].ToString();
                   double.TryParse(SQLConn.dr["UnitPrice"].ToString(), out _UnitPrice);
                   double.TryParse(SQLConn.dr["StocksOnHand"].ToString(), out _StocksOnHand);
                   Int32.TryParse(SQLConn.dr["ReorderLevel"].ToString(), out _ReorderLevel);
                   Int32.TryParse(SQLConn.dr["CategoryNo"].ToString(), out _CategoryNo);
                    // Int32.TryParse(SQLConn.dr["ProductCode"].ToString(), out _ProductCode);


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

    }
}
