namespace Outfit_POS
{
    partial class frm_Discount
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStocksIn = new System.Windows.Forms.Button();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnStocksIn);
            this.GroupBox1.Controls.Add(this.txtTA);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(11, 74);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(466, 148);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // btnStocksIn
            // 
            this.btnStocksIn.BackColor = System.Drawing.Color.Transparent;
            this.btnStocksIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStocksIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocksIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnStocksIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnStocksIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocksIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnStocksIn.Location = new System.Drawing.Point(318, 91);
            this.btnStocksIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnStocksIn.Name = "btnStocksIn";
            this.btnStocksIn.Size = new System.Drawing.Size(100, 34);
            this.btnStocksIn.TabIndex = 12;
            this.btnStocksIn.Text = "Aplicar";
            this.btnStocksIn.UseVisualStyleBackColor = false;
            this.btnStocksIn.Click += new System.EventHandler(this.btnStocksIn_Click);
            // 
            // txtTA
            // 
            this.txtTA.BackColor = System.Drawing.Color.White;
            this.txtTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTA.Location = new System.Drawing.Point(189, 32);
            this.txtTA.Margin = new System.Windows.Forms.Padding(4);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(229, 37);
            this.txtTA.TabIndex = 9;
            this.txtTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTA_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(11, 39);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(138, 25);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Descuento (%):";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 66);
            this.panel2.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(7, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Descuento Total:";
            // 
            // frm_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 233);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTA;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStocksIn;
    }
}
