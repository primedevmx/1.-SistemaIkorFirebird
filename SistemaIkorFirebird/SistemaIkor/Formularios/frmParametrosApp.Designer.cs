namespace SistemaIkor.Formularios
{
    partial class frmParametrosApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrosApp));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.gbxBDs = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroBDs = new SistemaIkor.uctrlTablaConFiltro();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbConfigurarBDs = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.gbxProduccion = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnActualizarCuentaProduc = new System.Windows.Forms.Button();
            this.txtProducPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbUsuarioAdmin = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnActualizarCuentaAdmin = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxUserMaster = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMasterPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasterUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSeleccionarUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tspTittle.SuspendLayout();
            this.gbxBDs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbx1.SuspendLayout();
            this.gbxProduccion.SuspendLayout();
            this.gbUsuarioAdmin.SuspendLayout();
            this.gbxUserMaster.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::SistemaIkor.Properties.Resources.bgDark2;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(784, 33);
            this.tspTittle.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(229, 30);
            this.toolStripLabel1.Text = "   Parámetros de la aplicación  ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = global::SistemaIkor.Properties.Resources.delete_26;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(30, 30);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miniToolStrip.Size = new System.Drawing.Size(778, 25);
            this.miniToolStrip.TabIndex = 2;
            // 
            // gbxBDs
            // 
            this.gbxBDs.BackColor = System.Drawing.Color.Transparent;
            this.gbxBDs.Controls.Add(this.groupBox1);
            this.gbxBDs.Controls.Add(this.gbx1);
            this.gbxBDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBDs.Location = new System.Drawing.Point(0, 33);
            this.gbxBDs.Name = "gbxBDs";
            this.gbxBDs.Size = new System.Drawing.Size(784, 413);
            this.gbxBDs.TabIndex = 3;
            this.gbxBDs.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uctrlTablaConFiltroBDs);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "* Configuración";
            // 
            // uctrlTablaConFiltroBDs
            // 
            this.uctrlTablaConFiltroBDs.bContador = true;
            this.uctrlTablaConFiltroBDs.bFiltro = true;
            this.uctrlTablaConFiltroBDs.bMostrarGrip = false;
            this.uctrlTablaConFiltroBDs.bTabStopFiltros = false;
            this.uctrlTablaConFiltroBDs.DataSource = null;
            this.uctrlTablaConFiltroBDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroBDs.dtrAgregarFila = null;
            this.uctrlTablaConFiltroBDs.Location = new System.Drawing.Point(3, 55);
            this.uctrlTablaConFiltroBDs.Name = "uctrlTablaConFiltroBDs";
            this.uctrlTablaConFiltroBDs.Size = new System.Drawing.Size(772, 157);
            this.uctrlTablaConFiltroBDs.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tsbConfigurarBDs});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(772, 39);
            this.toolStrip1.TabIndex = 2;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(177, 36);
            this.toolStripLabel2.Text = "    Bases de Datos  <<-  ";
            // 
            // tsbConfigurarBDs
            // 
            this.tsbConfigurarBDs.BackColor = System.Drawing.Color.Transparent;
            this.tsbConfigurarBDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbConfigurarBDs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbConfigurarBDs.ForeColor = System.Drawing.Color.White;
            this.tsbConfigurarBDs.Image = global::SistemaIkor.Properties.Resources.database_32;
            this.tsbConfigurarBDs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbConfigurarBDs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfigurarBDs.Name = "tsbConfigurarBDs";
            this.tsbConfigurarBDs.Size = new System.Drawing.Size(135, 36);
            this.tsbConfigurarBDs.Text = "Configurar BDs";
            this.tsbConfigurarBDs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbConfigurarBDs.ToolTipText = "Configuración de las bases de datos";
            this.tsbConfigurarBDs.Click += new System.EventHandler(this.tsbSeleccionarBDs_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "-> Descripción de la Instancia";
            // 
            // gbx1
            // 
            this.gbx1.BackColor = System.Drawing.Color.Transparent;
            this.gbx1.Controls.Add(this.gbxProduccion);
            this.gbx1.Controls.Add(this.gbUsuarioAdmin);
            this.gbx1.Controls.Add(this.gbxUserMaster);
            this.gbx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx1.Location = new System.Drawing.Point(3, 16);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(778, 179);
            this.gbx1.TabIndex = 6;
            this.gbx1.TabStop = false;
            // 
            // gbxProduccion
            // 
            this.gbxProduccion.Controls.Add(this.checkBox3);
            this.gbxProduccion.Controls.Add(this.btnActualizarCuentaProduc);
            this.gbxProduccion.Controls.Add(this.txtProducPass);
            this.gbxProduccion.Controls.Add(this.label5);
            this.gbxProduccion.Controls.Add(this.txtProducUser);
            this.gbxProduccion.Controls.Add(this.label6);
            this.gbxProduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxProduccion.Location = new System.Drawing.Point(3, 125);
            this.gbxProduccion.Name = "gbxProduccion";
            this.gbxProduccion.Size = new System.Drawing.Size(772, 51);
            this.gbxProduccion.TabIndex = 2;
            this.gbxProduccion.TabStop = false;
            this.gbxProduccion.Text = "Cuenta Producción";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnActualizarCuentaProduc
            // 
            this.btnActualizarCuentaProduc.Image = global::SistemaIkor.Properties.Resources.save_as_26;
            this.btnActualizarCuentaProduc.Location = new System.Drawing.Point(361, 8);
            this.btnActualizarCuentaProduc.Name = "btnActualizarCuentaProduc";
            this.btnActualizarCuentaProduc.Size = new System.Drawing.Size(40, 40);
            this.btnActualizarCuentaProduc.TabIndex = 9;
            this.btnActualizarCuentaProduc.UseVisualStyleBackColor = true;
            this.btnActualizarCuentaProduc.Visible = false;
            this.btnActualizarCuentaProduc.Click += new System.EventHandler(this.btnActualizarCuentaProduc_Click);
            // 
            // txtProducPass
            // 
            this.txtProducPass.Location = new System.Drawing.Point(254, 18);
            this.txtProducPass.Name = "txtProducPass";
            this.txtProducPass.Size = new System.Drawing.Size(100, 20);
            this.txtProducPass.TabIndex = 7;
            this.txtProducPass.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contraseña";
            this.label5.Visible = false;
            // 
            // txtProducUser
            // 
            this.txtProducUser.Enabled = false;
            this.txtProducUser.Location = new System.Drawing.Point(71, 18);
            this.txtProducUser.Name = "txtProducUser";
            this.txtProducUser.Size = new System.Drawing.Size(110, 20);
            this.txtProducUser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Usuario";
            // 
            // gbUsuarioAdmin
            // 
            this.gbUsuarioAdmin.Controls.Add(this.checkBox2);
            this.gbUsuarioAdmin.Controls.Add(this.btnActualizarCuentaAdmin);
            this.gbUsuarioAdmin.Controls.Add(this.txtAdminPass);
            this.gbUsuarioAdmin.Controls.Add(this.label3);
            this.gbUsuarioAdmin.Controls.Add(this.txtAdminUser);
            this.gbUsuarioAdmin.Controls.Add(this.label4);
            this.gbUsuarioAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuarioAdmin.Location = new System.Drawing.Point(3, 74);
            this.gbUsuarioAdmin.Name = "gbUsuarioAdmin";
            this.gbUsuarioAdmin.Size = new System.Drawing.Size(772, 51);
            this.gbUsuarioAdmin.TabIndex = 1;
            this.gbUsuarioAdmin.TabStop = false;
            this.gbUsuarioAdmin.Text = "Cuenta Administradora";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnActualizarCuentaAdmin
            // 
            this.btnActualizarCuentaAdmin.Image = global::SistemaIkor.Properties.Resources.save_as_26;
            this.btnActualizarCuentaAdmin.Location = new System.Drawing.Point(361, 8);
            this.btnActualizarCuentaAdmin.Name = "btnActualizarCuentaAdmin";
            this.btnActualizarCuentaAdmin.Size = new System.Drawing.Size(40, 40);
            this.btnActualizarCuentaAdmin.TabIndex = 8;
            this.btnActualizarCuentaAdmin.UseVisualStyleBackColor = true;
            this.btnActualizarCuentaAdmin.Visible = false;
            this.btnActualizarCuentaAdmin.Click += new System.EventHandler(this.btnActualizarCuentaAdmin_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(254, 18);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPass.TabIndex = 7;
            this.txtAdminPass.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            this.label3.Visible = false;
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Enabled = false;
            this.txtAdminUser.Location = new System.Drawing.Point(71, 18);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(110, 20);
            this.txtAdminUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario";
            // 
            // gbxUserMaster
            // 
            this.gbxUserMaster.Controls.Add(this.label7);
            this.gbxUserMaster.Controls.Add(this.checkBox1);
            this.gbxUserMaster.Controls.Add(this.txtMasterPass);
            this.gbxUserMaster.Controls.Add(this.label2);
            this.gbxUserMaster.Controls.Add(this.txtMasterUser);
            this.gbxUserMaster.Controls.Add(this.label1);
            this.gbxUserMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUserMaster.Location = new System.Drawing.Point(3, 16);
            this.gbxUserMaster.Name = "gbxUserMaster";
            this.gbxUserMaster.Size = new System.Drawing.Size(772, 58);
            this.gbxUserMaster.TabIndex = 0;
            this.gbxUserMaster.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = " * Cuenta Maestra";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMasterPass
            // 
            this.txtMasterPass.Enabled = false;
            this.txtMasterPass.Location = new System.Drawing.Point(254, 27);
            this.txtMasterPass.Name = "txtMasterPass";
            this.txtMasterPass.Size = new System.Drawing.Size(100, 20);
            this.txtMasterPass.TabIndex = 3;
            this.txtMasterPass.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            this.label2.Visible = false;
            // 
            // txtMasterUser
            // 
            this.txtMasterUser.Enabled = false;
            this.txtMasterUser.Location = new System.Drawing.Point(71, 27);
            this.txtMasterUser.Name = "txtMasterUser";
            this.txtMasterUser.Size = new System.Drawing.Size(110, 20);
            this.txtMasterUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSeleccionarUsers,
            this.toolStripSeparator1,
            this.toolStripLabel3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 33);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(784, 39);
            this.toolStrip2.TabIndex = 8;
            // 
            // tsbSeleccionarUsers
            // 
            this.tsbSeleccionarUsers.BackColor = System.Drawing.Color.Transparent;
            this.tsbSeleccionarUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSeleccionarUsers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSeleccionarUsers.ForeColor = System.Drawing.Color.White;
            this.tsbSeleccionarUsers.Image = global::SistemaIkor.Properties.Resources.View_Details_32;
            this.tsbSeleccionarUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSeleccionarUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeleccionarUsers.Name = "tsbSeleccionarUsers";
            this.tsbSeleccionarUsers.Size = new System.Drawing.Size(156, 36);
            this.tsbSeleccionarUsers.Text = "Consultar Cuentas";
            this.tsbSeleccionarUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbSeleccionarUsers.ToolTipText = "Consultar Cuentas";
            this.tsbSeleccionarUsers.Click += new System.EventHandler(this.tsbSeleccionarUsers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(132, 36);
            this.toolStripLabel3.Text = "    Usuarios <<-   ";
            // 
            // frmParametrosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 446);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gbxBDs);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParametrosApp";
            this.Text = "frmParametrosApp";
            this.Load += new System.EventHandler(this.frmParametrosApp_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.gbxBDs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbx1.ResumeLayout(false);
            this.gbxProduccion.ResumeLayout(false);
            this.gbxProduccion.PerformLayout();
            this.gbUsuarioAdmin.ResumeLayout(false);
            this.gbUsuarioAdmin.PerformLayout();
            this.gbxUserMaster.ResumeLayout(false);
            this.gbxUserMaster.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.GroupBox gbxBDs;
        private System.Windows.Forms.GroupBox groupBox1;
        private uctrlTablaConFiltro uctrlTablaConFiltroBDs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.GroupBox gbxProduccion;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnActualizarCuentaProduc;
        private System.Windows.Forms.TextBox txtProducPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProducUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbUsuarioAdmin;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnActualizarCuentaAdmin;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxUserMaster;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMasterPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasterUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripButton tsbConfigurarBDs;
        public System.Windows.Forms.ToolStripButton tsbSeleccionarUsers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}