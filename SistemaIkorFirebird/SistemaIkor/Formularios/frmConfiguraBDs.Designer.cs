namespace SistemaIkor.Formularios
{
    partial class frmConfiguraBDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguraBDs));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregarBD = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiarPantalla = new System.Windows.Forms.ToolStripButton();
            this.tsbProbarConn = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarBD = new System.Windows.Forms.ToolStripButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUsuarioAdmin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswodBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uctrlTablaConFiltroBDs = new SistemaIkor.uctrlTablaConFiltro();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tspTittle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.gbUsuarioAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tspTittle.Size = new System.Drawing.Size(1071, 33);
            this.tspTittle.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(250, 30);
            this.toolStripLabel1.Text = "  Configuración de las instancias  ";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreBD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 200);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(434, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "->>    Descripcion a mostrar en el Combo de Reportes";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(135, 99);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(284, 20);
            this.txtDescrip.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "-> Descripcion de la BD";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::SistemaIkor.Properties.Resources.bgDark2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 133);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1065, 25);
            this.toolStrip1.TabIndex = 41;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(1062, 22);
            this.toolStripLabel2.Text = resources.GetString("toolStripLabel2.Text");
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbAgregarBD,
            this.tsbLimpiarPantalla,
            this.tsbProbarConn,
            this.tsbEliminarBD});
            this.toolStrip2.Location = new System.Drawing.Point(3, 158);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(1065, 39);
            this.toolStrip2.TabIndex = 12;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAgregarBD
            // 
            this.tsbAgregarBD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAgregarBD.BackColor = System.Drawing.Color.Transparent;
            this.tsbAgregarBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbAgregarBD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAgregarBD.ForeColor = System.Drawing.Color.White;
            this.tsbAgregarBD.Image = global::SistemaIkor.Properties.Resources.add_database_32;
            this.tsbAgregarBD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAgregarBD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarBD.Name = "tsbAgregarBD";
            this.tsbAgregarBD.Size = new System.Drawing.Size(113, 36);
            this.tsbAgregarBD.Text = "Agregar BD";
            this.tsbAgregarBD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbAgregarBD.ToolTipText = "Configuración de las bases de datos";
            this.tsbAgregarBD.Click += new System.EventHandler(this.tsbAgregarBD_Click);
            // 
            // tsbLimpiarPantalla
            // 
            this.tsbLimpiarPantalla.BackColor = System.Drawing.Color.Transparent;
            this.tsbLimpiarPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbLimpiarPantalla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLimpiarPantalla.ForeColor = System.Drawing.Color.White;
            this.tsbLimpiarPantalla.Image = global::SistemaIkor.Properties.Resources.monitor_32;
            this.tsbLimpiarPantalla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLimpiarPantalla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiarPantalla.Name = "tsbLimpiarPantalla";
            this.tsbLimpiarPantalla.Size = new System.Drawing.Size(140, 36);
            this.tsbLimpiarPantalla.Text = "Limpiar Pantalla";
            this.tsbLimpiarPantalla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbLimpiarPantalla.ToolTipText = "Limpiar Pantalla";
            this.tsbLimpiarPantalla.Click += new System.EventHandler(this.tsbLimpiarPantalla_Click);
            // 
            // tsbProbarConn
            // 
            this.tsbProbarConn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbProbarConn.BackColor = System.Drawing.Color.Transparent;
            this.tsbProbarConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbProbarConn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProbarConn.ForeColor = System.Drawing.Color.White;
            this.tsbProbarConn.Image = global::SistemaIkor.Properties.Resources.accept_database_32;
            this.tsbProbarConn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProbarConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProbarConn.Name = "tsbProbarConn";
            this.tsbProbarConn.Size = new System.Drawing.Size(149, 36);
            this.tsbProbarConn.Text = "Probar Conexión ";
            this.tsbProbarConn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbProbarConn.ToolTipText = "Configuración de las bases de datos";
            this.tsbProbarConn.Visible = false;
            this.tsbProbarConn.Click += new System.EventHandler(this.tsbProbarConn_Click);
            // 
            // tsbEliminarBD
            // 
            this.tsbEliminarBD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarBD.BackColor = System.Drawing.Color.Transparent;
            this.tsbEliminarBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbEliminarBD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEliminarBD.ForeColor = System.Drawing.Color.White;
            this.tsbEliminarBD.Image = global::SistemaIkor.Properties.Resources.delete_database_32;
            this.tsbEliminarBD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEliminarBD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarBD.Name = "tsbEliminarBD";
            this.tsbEliminarBD.Size = new System.Drawing.Size(111, 36);
            this.tsbEliminarBD.Text = "Eliminar BD";
            this.tsbEliminarBD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminarBD.ToolTipText = "Configuración de las bases de datos";
            this.tsbEliminarBD.Visible = false;
            this.tsbEliminarBD.Click += new System.EventHandler(this.tsbEliminarBD_Click);
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
            this.label7.Size = new System.Drawing.Size(300, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "->>    Escriba la IP de la maquina donde se encuentra la BD";
            // 
            // txtNombreBD
            // 
            this.txtNombreBD.Location = new System.Drawing.Point(111, 70);
            this.txtNombreBD.Name = "txtNombreBD";
            this.txtNombreBD.Size = new System.Drawing.Size(307, 20);
            this.txtNombreBD.TabIndex = 40;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-> Ruta de la BD";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(99, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(319, 20);
            this.txtIP.TabIndex = 20;
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
            // gbUsuarioAdmin
            // 
            this.gbUsuarioAdmin.Controls.Add(this.label6);
            this.gbUsuarioAdmin.Controls.Add(this.txtPasswodBD);
            this.gbUsuarioAdmin.Controls.Add(this.label1);
            this.gbUsuarioAdmin.Controls.Add(this.txtUserBD);
            this.gbUsuarioAdmin.Controls.Add(this.label4);
            this.gbUsuarioAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuarioAdmin.Location = new System.Drawing.Point(0, 33);
            this.gbUsuarioAdmin.Name = "gbUsuarioAdmin";
            this.gbUsuarioAdmin.Size = new System.Drawing.Size(1071, 47);
            this.gbUsuarioAdmin.TabIndex = 12;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "->Password";
            // 
            // txtUserBD
            // 
            this.txtUserBD.Location = new System.Drawing.Point(37, 18);
            this.txtUserBD.Name = "txtUserBD";
            this.txtUserBD.Size = new System.Drawing.Size(151, 20);
            this.txtUserBD.TabIndex = 1;
            this.txtUserBD.Text = "sysdba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "->ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uctrlTablaConFiltroBDs);
            this.panel1.Controls.Add(this.toolStrip3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 496);
            this.panel1.TabIndex = 14;
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
            this.uctrlTablaConFiltroBDs.Location = new System.Drawing.Point(0, 0);
            this.uctrlTablaConFiltroBDs.Name = "uctrlTablaConFiltroBDs";
            this.uctrlTablaConFiltroBDs.Size = new System.Drawing.Size(1071, 471);
            this.uctrlTablaConFiltroBDs.TabIndex = 1;
            this.uctrlTablaConFiltroBDs.GridDatos_DoubleClick += new SistemaIkor.uctrlTablaConFiltro.GridDatos_DoubleClickEventHandler(this.uctrlTablaConFiltroBDs_GridDatos_DoubleClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackgroundImage = global::SistemaIkor.Properties.Resources.bgDark2;
            this.toolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Location = new System.Drawing.Point(0, 471);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip3.Size = new System.Drawing.Size(1071, 25);
            this.toolStrip3.TabIndex = 4;
            // 
            // frmConfiguraBDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 776);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbUsuarioAdmin);
            this.Controls.Add(this.tspTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfiguraBDs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - Configuración de las bases de datos";
            this.Load += new System.EventHandler(this.frmConfiguraBDs_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gbUsuarioAdmin.ResumeLayout(false);
            this.gbUsuarioAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbUsuarioAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswodBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private uctrlTablaConFiltro uctrlTablaConFiltroBDs;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbAgregarBD;
        public System.Windows.Forms.ToolStripButton tsbEliminarBD;
        public System.Windows.Forms.ToolStripButton tsbLimpiarPantalla;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ToolStripButton tsbProbarConn;
    }
}