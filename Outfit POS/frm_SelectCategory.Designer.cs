namespace Outfit_POS
{
    partial class frm_SelectCategory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 66);
            this.panel2.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(19, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Seleccionar Categoría:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ListView1);
            this.GroupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(11, 160);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(748, 261);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(4, 21);
            this.ListView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(740, 236);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Category No";
            this.ColumnHeader1.Width = 101;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Category Name";
            this.ColumnHeader2.Width = 173;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Description";
            this.ColumnHeader3.Width = 339;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCatName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 68);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(748, 85);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(270, 36);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(470, 24);
            this.txtCatName.TabIndex = 0;
            this.txtCatName.TextChanged += new System.EventHandler(this.txtCatName_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 39);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(253, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Ingrese el Nombre de la Categoría:";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::Outfit_POS.Properties.Resources.cerrar;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(737, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(33, 26);
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frm_SelectCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 436);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_SelectCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSelectCategory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.Label lblTitle;
            internal System.Windows.Forms.GroupBox GroupBox2;
            internal System.Windows.Forms.ListView ListView1;
            internal System.Windows.Forms.ColumnHeader ColumnHeader1;
            internal System.Windows.Forms.ColumnHeader ColumnHeader2;
            internal System.Windows.Forms.ColumnHeader ColumnHeader3;
            internal System.Windows.Forms.GroupBox GroupBox1;
            internal System.Windows.Forms.TextBox txtCatName;
            internal System.Windows.Forms.Label Label1;
            private System.Windows.Forms.PictureBox picClose;
        }
    }