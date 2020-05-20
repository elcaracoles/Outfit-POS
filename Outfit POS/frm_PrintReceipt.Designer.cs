namespace Outfit_POS
{
    partial class frm_PrintReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CompanyAddress = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblThank = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.vat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.CompanyTINNumber = new System.Windows.Forms.Label();
            this.CompanyPhoneNo = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.CompanyAddress);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.dgw);
            this.Panel1.Controls.Add(this.lblTime);
            this.Panel1.Controls.Add(this.lblEmpName);
            this.Panel1.Controls.Add(this.lblDate);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.lblInvoice);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.CompanyTINNumber);
            this.Panel1.Controls.Add(this.CompanyPhoneNo);
            this.Panel1.Controls.Add(this.CompanyName);
            this.Panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(8, 10);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(404, 427);
            this.Panel1.TabIndex = 2;
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyAddress.Location = new System.Drawing.Point(1, 42);
            this.CompanyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.Size = new System.Drawing.Size(403, 17);
            this.CompanyAddress.TabIndex = 47;
            this.CompanyAddress.Text = "[Company Address Here]";
            this.CompanyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lblThank);
            this.Panel2.Controls.Add(this.lblOR);
            this.Panel2.Controls.Add(this.lblLine);
            this.Panel2.Controls.Add(this.lblChange);
            this.Panel2.Controls.Add(this.lblSubtotal);
            this.Panel2.Controls.Add(this.lblCash);
            this.Panel2.Controls.Add(this.change);
            this.Panel2.Controls.Add(this.subTotal);
            this.Panel2.Controls.Add(this.Cash);
            this.Panel2.Controls.Add(this.lblVat);
            this.Panel2.Controls.Add(this.vat);
            this.Panel2.Controls.Add(this.lblTotal);
            this.Panel2.Controls.Add(this.TotalAmount);
            this.Panel2.Location = new System.Drawing.Point(12, 230);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(375, 190);
            this.Panel2.TabIndex = 46;
            // 
            // lblThank
            // 
            this.lblThank.AutoSize = true;
            this.lblThank.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThank.Location = new System.Drawing.Point(80, 166);
            this.lblThank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThank.Name = "lblThank";
            this.lblThank.Size = new System.Drawing.Size(195, 17);
            this.lblThank.TabIndex = 55;
            this.lblThank.Text = "Thank You Come Again!";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(59, 146);
            this.lblOR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(242, 17);
            this.lblOR.TabIndex = 56;
            this.lblOR.Text = "THIS IS YOUR OFFICIAL RECEPIT";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(3, 127);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(338, 17);
            this.lblLine.TabIndex = 54;
            this.lblLine.Text = "==============================";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(259, 95);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(107, 20);
            this.lblChange.TabIndex = 48;
            this.lblChange.Text = "0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(259, 30);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(107, 16);
            this.lblSubtotal.TabIndex = 49;
            this.lblSubtotal.Text = "0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(259, 73);
            this.lblCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(107, 18);
            this.lblCash.TabIndex = 50;
            this.lblCash.Text = "0.00";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(1, 95);
            this.change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(127, 23);
            this.change.TabIndex = 52;
            this.change.Text = "Change    :";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(1, 30);
            this.subTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(85, 17);
            this.subTotal.TabIndex = 51;
            this.subTotal.Text = "Sub Total :";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.Location = new System.Drawing.Point(1, 73);
            this.Cash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(114, 17);
            this.Cash.TabIndex = 53;
            this.Cash.Text = "Cash             :";
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(259, 10);
            this.lblVat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(107, 16);
            this.lblVat.TabIndex = 44;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vat
            // 
            this.vat.AutoSize = true;
            this.vat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vat.Location = new System.Drawing.Point(1, 11);
            this.vat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(87, 17);
            this.vat.TabIndex = 47;
            this.vat.Text = "Vat          :";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(259, 52);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 16);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(1, 52);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(113, 17);
            this.TotalAmount.TabIndex = 46;
            this.TotalAmount.Text = "Total Amount :";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.ColumnHeadersHeight = 24;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemQuantity,
            this.Description,
            this.UnitPrice,
            this.Amount});
            this.dgw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.White;
            this.dgw.Location = new System.Drawing.Point(-24, 159);
            this.dgw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw.RowHeadersWidth = 25;
            this.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw.RowTemplate.Height = 18;
            this.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw.Size = new System.Drawing.Size(431, 64);
            this.dgw.TabIndex = 39;
            // 
            // ItemQuantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemQuantity.FillWeight = 7.575758F;
            this.ItemQuantity.HeaderText = "Qty";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.Width = 30;
            // 
            // Description
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Description.DefaultCellStyle = dataGridViewCellStyle4;
            this.Description.FillWeight = 69.97607F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 130;
            // 
            // UnitPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "#,##0.00";
            dataGridViewCellStyle5.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.UnitPrice.FillWeight = 131.1945F;
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 60;
            // 
            // Amount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "#,##0.00";
            dataGridViewCellStyle6.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.FillWeight = 191.2536F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 70;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(253, 138);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(124, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(108, 138);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(47, 17);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(236, 119);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(5, 138);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 17);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Cashier :";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(108, 119);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(57, 17);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "Invoice";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(5, 119);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 17);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Invoice No :";
            // 
            // CompanyTINNumber
            // 
            this.CompanyTINNumber.AutoSize = true;
            this.CompanyTINNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTINNumber.Location = new System.Drawing.Point(103, 82);
            this.CompanyTINNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyTINNumber.Name = "CompanyTINNumber";
            this.CompanyTINNumber.Size = new System.Drawing.Size(149, 17);
            this.CompanyTINNumber.TabIndex = 0;
            this.CompanyTINNumber.Text = "TIN#: 119-239-518";
            // 
            // CompanyPhoneNo
            // 
            this.CompanyPhoneNo.AutoSize = true;
            this.CompanyPhoneNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyPhoneNo.Location = new System.Drawing.Point(76, 64);
            this.CompanyPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyPhoneNo.Name = "CompanyPhoneNo";
            this.CompanyPhoneNo.Size = new System.Drawing.Size(207, 17);
            this.CompanyPhoneNo.TabIndex = 0;
            this.CompanyPhoneNo.Text = "Contact No : 796-434-9402";
            // 
            // CompanyName
            // 
            this.CompanyName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(1, 21);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(403, 17);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "[Company Name Here]";
            this.CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_PrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 444);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PrintReceipt";
            this.Load += new System.EventHandler(this.frmPrintReceipt_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label CompanyTINNumber;
        private System.Windows.Forms.Label CompanyPhoneNo;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label lblThank;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label vat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label CompanyAddress;
        private System.Drawing.Printing.PrintDocument PrintDocument1;
    }
}