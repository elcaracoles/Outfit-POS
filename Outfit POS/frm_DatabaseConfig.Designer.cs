﻿namespace Outfit_POS
{
    partial class frm_DatabaseConfig
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtServerHost = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cmdSave);
            this.GroupBox1.Controls.Add(this.txtServerHost);
            this.GroupBox1.Controls.Add(this.cmdClose);
            this.GroupBox1.Controls.Add(this.cmdTest);
            this.GroupBox1.Controls.Add(this.txtUserName);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtPort);
            this.GroupBox1.Controls.Add(this.txtPassword);
            this.GroupBox1.Controls.Add(this.txtDatabase);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 84);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(439, 298);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Conectar con Servidor MySQL";
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cmdSave.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(168, 206);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 78);
            this.cmdSave.TabIndex = 22;
            this.cmdSave.Text = "Guardar";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtServerHost
            // 
            this.txtServerHost.BackColor = System.Drawing.Color.White;
            this.txtServerHost.Location = new System.Drawing.Point(168, 40);
            this.txtServerHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(231, 24);
            this.txtServerHost.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cmdClose.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(276, 206);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 78);
            this.cmdClose.TabIndex = 23;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.BackColor = System.Drawing.Color.Gainsboro;
            this.cmdTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTest.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cmdTest.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdTest.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTest.Location = new System.Drawing.Point(60, 206);
            this.cmdTest.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(100, 78);
            this.cmdTest.TabIndex = 21;
            this.cmdTest.Text = "Probar";
            this.cmdTest.UseVisualStyleBackColor = false;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(168, 103);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(231, 24);
            this.txtUserName.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(29, 107);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Usuario:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(29, 172);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(117, 17);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Base de Datos:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(29, 75);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 17);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Puerto:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 139);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 17);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Contraseña:";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(168, 71);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(231, 24);
            this.txtPort.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(168, 136);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(231, 24);
            this.txtPassword.TabIndex = 3;
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.White;
            this.txtDatabase.Location = new System.Drawing.Point(168, 165);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(231, 24);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 43);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 17);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Servidor Host:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Font = new System.Drawing.Font("Segoe Print", 7.8F);
            this.Panel1.Location = new System.Drawing.Point(-28, -1);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(673, 68);
            this.Panel1.TabIndex = 28;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(59, 21);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(404, 43);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Configuración de Base de Datos";
            // 
            // frm_DatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 393);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DatabaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDatabaseConfig_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            internal System.Windows.Forms.GroupBox GroupBox1;
            internal System.Windows.Forms.Button cmdSave;
            internal System.Windows.Forms.TextBox txtServerHost;
            internal System.Windows.Forms.Button cmdClose;
            internal System.Windows.Forms.Button cmdTest;
            internal System.Windows.Forms.TextBox txtUserName;
            internal System.Windows.Forms.Label Label2;
            internal System.Windows.Forms.Label Label4;
            internal System.Windows.Forms.Label Label5;
            internal System.Windows.Forms.Label Label3;
            internal System.Windows.Forms.TextBox txtPort;
            internal System.Windows.Forms.TextBox txtPassword;
            internal System.Windows.Forms.TextBox txtDatabase;
            internal System.Windows.Forms.Label Label1;
            internal System.Windows.Forms.Panel Panel1;
            internal System.Windows.Forms.Label Label6;
        }
    }