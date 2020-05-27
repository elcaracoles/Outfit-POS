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
        Boolean grabado;
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
            invoiceNo.Text = nInvoice;
            grabado = false;

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            ListViewItem x = null;
            x = new ListViewItem((listView1.Items.Count +1).ToString());
            x.SubItems.Add(label18.Text);
            x.SubItems.Add(txtDescrip.Text);
            x.SubItems.Add(txtPrice.Text);
            x.SubItems.Add(txtCant.Text);
            x.SubItems.Add(txtTotal.Text);
            x.SubItems.Add("0");
            
            listView1.Items.Add(x);
            txtTotalAmount.Text = total_e().ToString();
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
            txtTotalAmount.Text = total_e().ToString();
            textBox10.Text = total_p().ToString();
            txtBar.Focus();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
               
                product pr = new product(txtCodprod.Text, 1);
                fill_Product(pr);
               
                ch_texbox();
            }
        }
        private void ch_texbox() {
            if (txtCodprod.Enabled == true && txtBar.Enabled == true && txtCant.ReadOnly == true)
            {

               
                txtCodprod.Enabled = false;
                txtBar.Enabled = false;
                
                txtCant.ReadOnly = false;
                txtCant.Focus();
            }
            else {
                txtCodprod.Enabled = true;
                txtBar.Enabled = true;
                txtCant.ReadOnly = true ;
                txtBar.Text = "";
                txtCodprod.Text = "";
                txtCant.Text = "1";
                txtBar.Focus();

            }
        }

        private void fill_Product(product pr) {
            if (pr.StocksOnHand > 0) { 
            txtBar.Text = pr.Barcode;
            txtCodprod.Text = pr.ProductCode;
            txtDescrip.Text = pr.Description;
            txtPrice.Text = pr.UnitPrice.ToString();
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
            double discount = 0;
            foreach (ListViewItem lstItem in listView1.Items) // listView has ListViewItem objects
            {
                total += double.Parse(lstItem.SubItems[5].Text); // Columns 4
            }
            double.TryParse(textBox13.Text,out discount);
            total = total - (total * discount / 100);
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

                product pr = new product(txtBar.Text, 2);
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
               
                double.TryParse(txtPrice.Text,out precioU);
                int.TryParse(txtCant.Text, out Cantidad);
                total = precioU * Cantidad;
                txtTotal.Text = total.ToString();
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
            InvoiceNo = invoiceNo.Text;
            NonVatTotal = txtVatAmount.Text;
            VatAmount = txtNonVatTotal.Text;
            TotalAmount = txtTotalAmount.Text;
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
            invoiceNo.Text = get_Invoice();
            txtDescrip.Text = "";
            txtPrice.Text = "0.00";
            txtCant.Text = "1";
            txtTotal.Text = "0";
            txtVatAmount.Text = "0";
            textBox10.Text = "0";
            txtNonVatTotal.Text = "0";
            txtTotalAmount.Text = "0";

            txtBar.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_FindProduct fndProduct = new frm_FindProduct();
                       
            if (fndProduct.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.txtCodprod.Text = fndProduct.productID.ToString();
                product pr = new product(txtCodprod.Text, 1);
                fill_Product(pr);

                ch_texbox();

            }
            else
            {
                this.txtCodprod.Text = "";
            }
            fndProduct.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Discount fDiscount = new frm_Discount();

            if (fDiscount.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.textBox13.Text = fDiscount.discount.ToString();
                txtTotalAmount.Text = total_e().ToString();
                textBox10.Text = total_p().ToString();

            }
            else
            {
                this.txtCodprod.Text = "";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total = 0;
            double.TryParse(txtTotalAmount.Text, out total);
            AddTransaction();
            AddTransactionDetails();
            UpdateProductQuantity();
            frm_Payment pay = new frm_Payment(invoiceNo.Text, total);
            if( pay.ShowDialog(this) == DialogResult.OK) {
            frm_PrintReceipt pr = new frm_PrintReceipt(invoiceNo.Text);//label9.Text);
                pr.ShowDialog();

           }
            

        }
        #region transacciones
        private void AddTransaction()
        {
            string InvoiceNo,  NonVatTotal, VatAmount, TotalAmount;
            InvoiceNo = invoiceNo.Text;
            NonVatTotal = txtVatAmount.Text;
            VatAmount = txtNonVatTotal.Text;
            TotalAmount = txtTotalAmount.Text;
            try
            {
                 SQLConn.ConnDB();
                SQLConn.cmd.Connection = SQLConn.conn;
                SQLConn.cmd.CommandText = "SELECT COUNT(*) FROM transactions where InvoiceNo=" + InvoiceNo;
                //string result = cConvert.ToInt32(SQLConn.cmd.ExecuteScalar());// .ToString();
                Int32 count = Convert.ToInt32(SQLConn.cmd.ExecuteScalar());// (Int32)SQLConn.cmd.ExecuteScalar();
                if (count == 0)
                    SQLConn.sqL = "insert into transactions (InvoiceNo,TDate,TTime,NonVatTotal,VatAmount,TotalAmount,StaffID) values (" + InvoiceNo + ",DATE_FORMAT(NOW(), '%m/%d/%Y'),time(Now())," + NonVatTotal + "," + VatAmount + "," + TotalAmount + "," + StaffID.ToString() + ")";
                else

                    SQLConn.sqL = "update transactions set TDate=DATE_FORMAT(NOW(), '%m/%d/%Y'),TTime=time(Now()), NonVatTotal=" + NonVatTotal + ", VatAmount=" + VatAmount + ", TotalAmount=" + TotalAmount + " where InvoiceNo=" + InvoiceNo ;

                
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
        private void AddTransactionDetails()
        {
            string ProductNo, ItemPrice, Quantity, Discount;
            try
            {
                foreach (ListViewItem item in listView1.Items)//recorres la lista
                {

                    ProductNo = item.SubItems[1].Text;
                    ItemPrice = item.SubItems[3].Text;
                    Quantity = item.SubItems[4].Text;
                    Discount = item.SubItems[6].Text;
                    SQLConn.ConnDB();
                    SQLConn.cmd.Connection = SQLConn.conn;
                    SQLConn.cmd.CommandText = "SELECT COUNT(*) FROM transactiondetails where InvoiceNo=" + invoiceNo.Text+ " and ProductNo="+ProductNo;
                    Int32 count = Convert.ToInt32(SQLConn.cmd.ExecuteScalar());
                    if (count == 0)
                        SQLConn.sqL = "insert into transactiondetails (InvoiceNo,ProductNo,ItemPrice,Quantity,Discount) values (" + invoiceNo.Text + "," + ProductNo + "," + ItemPrice + "," + Quantity + "," + Discount + ")";

                    else
                        SQLConn.sqL = "update transactions set ItemPrice=" + ItemPrice + ", Quantity=" + Quantity + ", Discount=" + Discount + " where InvoiceNo=" + invoiceNo.Text + "and ProductNo=" + ProductNo;



                   // SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.cmd.ExecuteNonQuery();



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
        private void UpdateProductQuantity()
        {
            try
            {
                string ProductNo, Quantity;
                foreach (ListViewItem item in listView1.Items)//recorres la lista
                {

                    ProductNo = item.SubItems[1].Text;

                    Quantity = item.SubItems[4].Text;
                   
                    SQLConn.sqL = "update product set StocksOnHand=StocksOnHand-" + Quantity + " where  ProductNo=" + ProductNo;
                    SQLConn.ConnDB();
                    SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                    SQLConn.cmd.ExecuteNonQuery();
                                       
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
        #endregion

        private void button7_Click(object sender, EventArgs e)
        {
            frm_reprint print = new frm_reprint();
            print.ShowDialog();
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
