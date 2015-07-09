namespace SistemaIkor.Formularios
{
    partial class frmRegistraServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistraServidor));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbUsuarioAdmin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswodBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserBD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tspTittle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUsuarioAdmin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(968, 25);
            this.tspTittle.TabIndex = 3;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(295, 22);
            this.toolStripLabel1.Text = "  Registra los  parametros del servidor - ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = global::SistemaIkor.Properties.Resources.delete_26;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTestConnection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCC);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.Transparent;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Location = new System.Drawing.Point(15, 87);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(124, 23);
            this.btnTestConnection.TabIndex = 80;
            this.btnTestConnection.Text = "Probar &Conexión";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = " >> Instancia del Servidor ->> Cadena de Conexión:";
            // 
            // txtCC
            // 
            this.txtCC.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCC.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCC.Location = new System.Drawing.Point(15, 46);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(941, 27);
            this.txtCC.TabIndex = 50;
            this.txtCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCC_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(882, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "&Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(801, 87);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 60;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbUsuarioAdmin
            // 
            this.gbUsuarioAdmin.Controls.Add(this.label6);
            this.gbUsuarioAdmin.Controls.Add(this.txtPasswodBD);
            this.gbUsuarioAdmin.Controls.Add(this.label4);
            this.gbUsuarioAdmin.Controls.Add(this.txtUserBD);
            this.gbUsuarioAdmin.Controls.Add(this.label12);
            this.gbUsuarioAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuarioAdmin.Location = new System.Drawing.Point(0, 25);
            this.gbUsuarioAdmin.Name = "gbUsuarioAdmin";
            this.gbUsuarioAdmin.Size = new System.Drawing.Size(968, 49);
            this.gbUsuarioAdmin.TabIndex = 16;
            this.gbUsuarioAdmin.TabStop = false;
            this.gbUsuarioAdmin.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(433, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "->>    ID = \'sysdba \'  ,  Password = \'masterkey\' ";
            // 
            // txtPasswodBD
            // 
            this.txtPasswodBD.Location = new System.Drawing.Point(263, 18);
            this.txtPasswodBD.Name = "txtPasswodBD";
            this.txtPasswodBD.Size = new System.Drawing.Size(151, 20);
            this.txtPasswodBD.TabIndex = 10;
            this.txtPasswodBD.Text = "masterkey";
            this.txtPasswodBD.TextChanged += new System.EventHandler(this.txtUserBD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "->Password";
            // 
            // txtUserBD
            // 
            this.txtUserBD.Location = new System.Drawing.Point(37, 18);
            this.txtUserBD.Name = "txtUserBD";
            this.txtUserBD.Size = new System.Drawing.Size(151, 20);
            this.txtUserBD.TabIndex = 1;
            this.txtUserBD.Text = "sysdba";
            this.txtUserBD.TextChanged += new System.EventHandler(this.txtUserBD_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "->ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombreBD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRuta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 107);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(433, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "->>    dbSecurityIkor.FDB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(433, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "->>    C:\\\\SistemaIkor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(433, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "->>    Escriba la IP y Puerto de la maquina donde se encuentra la BD ->192.168.48" +
    ".182/3051";
            // 
            // txtNombreBD
            // 
            this.txtNombreBD.Location = new System.Drawing.Point(111, 70);
            this.txtNombreBD.Name = "txtNombreBD";
            this.txtNombreBD.Size = new System.Drawing.Size(307, 20);
            this.txtNombreBD.TabIndex = 40;
            this.txtNombreBD.Text = "dbSecurityIkor.GDB";
            this.txtNombreBD.TextChanged += new System.EventHandler(this.txtUserBD_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "-> Nombre de la BD";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(99, 44);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(319, 20);
            this.txtRuta.TabIndex = 30;
            this.txtRuta.Text = "C:\\\\SistemaIkor";
            this.txtRuta.TextChanged += new System.EventHandler(this.txtUserBD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-> Ruta de la BD";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(99, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(319, 20);
            this.txtIP.TabIndex = 20;
            this.txtIP.Text = "localhost";
            this.txtIP.TextChanged += new System.EventHandler(this.txtUserBD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-> IP del Servidor";
            // 
            // frmRegistraServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbUsuarioAdmin);
            this.Controls.Add(this.tspTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistraServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - Parametros del servidor";
            this.Load += new System.EventHandler(this.frmRegistraServidor_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUsuarioAdmin.ResumeLayout(false);
            this.gbUsuarioAdmin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbUsuarioAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswodBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserBD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestConnection;
    }
}