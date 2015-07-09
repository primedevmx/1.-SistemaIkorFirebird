namespace SistemaIkor.Formularios
{
    partial class frmEliminaReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminaReporte));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDREP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreRep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreBD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregarBD = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiarPantalla = new System.Windows.Forms.ToolStripButton();
            this.tsbProbarConn = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarBD = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminaRep = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiaPantalla = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroREPs = new SistemaIkor.uctrlTablaConFiltro();
            this.tspTittle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.tspTittle.Size = new System.Drawing.Size(813, 33);
            this.tspTittle.TabIndex = 15;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(223, 30);
            this.toolStripLabel1.Text = "   Eliminación de los Reportes ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-> ID del Reporte";
            // 
            // txtIDREP
            // 
            this.txtIDREP.Enabled = false;
            this.txtIDREP.Location = new System.Drawing.Point(99, 20);
            this.txtIDREP.Name = "txtIDREP";
            this.txtIDREP.Size = new System.Drawing.Size(319, 20);
            this.txtIDREP.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-> Nombre del Reporte";
            // 
            // txtNombreRep
            // 
            this.txtNombreRep.Enabled = false;
            this.txtNombreRep.Location = new System.Drawing.Point(129, 46);
            this.txtNombreRep.Name = "txtNombreRep";
            this.txtNombreRep.Size = new System.Drawing.Size(289, 20);
            this.txtNombreRep.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "-> Nombre de la BD";
            // 
            // txtNombreBD
            // 
            this.txtNombreBD.Enabled = false;
            this.txtNombreBD.Location = new System.Drawing.Point(111, 72);
            this.txtNombreBD.Name = "txtNombreBD";
            this.txtNombreBD.Size = new System.Drawing.Size(307, 20);
            this.txtNombreBD.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(433, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "->>    ID del Reporte registrado en la BD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(433, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "->>    Nombre del Reporte asignado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(433, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "->>    dbSecurityIkor.FDB";
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
            this.miniToolStrip.Size = new System.Drawing.Size(807, 39);
            this.miniToolStrip.TabIndex = 12;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreBD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreRep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDREP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 145);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su reporte  ->>";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbEliminaRep,
            this.tsbLimpiaPantalla});
            this.toolStrip1.Location = new System.Drawing.Point(3, 103);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(807, 39);
            this.toolStrip1.TabIndex = 51;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbEliminaRep
            // 
            this.tsbEliminaRep.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminaRep.BackColor = System.Drawing.Color.Transparent;
            this.tsbEliminaRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbEliminaRep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEliminaRep.ForeColor = System.Drawing.Color.White;
            this.tsbEliminaRep.Image = global::SistemaIkor.Properties.Resources.add_database_32;
            this.tsbEliminaRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEliminaRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminaRep.Name = "tsbEliminaRep";
            this.tsbEliminaRep.Size = new System.Drawing.Size(144, 36);
            this.tsbEliminaRep.Text = "Eliminar Reporte";
            this.tsbEliminaRep.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminaRep.Click += new System.EventHandler(this.tsbEliminaRep_Click);
            // 
            // tsbLimpiaPantalla
            // 
            this.tsbLimpiaPantalla.BackColor = System.Drawing.Color.Transparent;
            this.tsbLimpiaPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbLimpiaPantalla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLimpiaPantalla.ForeColor = System.Drawing.Color.White;
            this.tsbLimpiaPantalla.Image = global::SistemaIkor.Properties.Resources.monitor_32;
            this.tsbLimpiaPantalla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLimpiaPantalla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiaPantalla.Name = "tsbLimpiaPantalla";
            this.tsbLimpiaPantalla.Size = new System.Drawing.Size(140, 36);
            this.tsbLimpiaPantalla.Text = "Limpiar Pantalla";
            this.tsbLimpiaPantalla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbLimpiaPantalla.ToolTipText = "Limpiar Pantalla";
            this.tsbLimpiaPantalla.Click += new System.EventHandler(this.tsbLimpiaPantalla_Click);
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
            this.toolStrip2.Size = new System.Drawing.Size(807, 39);
            this.toolStrip2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uctrlTablaConFiltroREPs);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 234);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // uctrlTablaConFiltroREPs
            // 
            this.uctrlTablaConFiltroREPs.bContador = true;
            this.uctrlTablaConFiltroREPs.bFiltro = true;
            this.uctrlTablaConFiltroREPs.bMostrarGrip = false;
            this.uctrlTablaConFiltroREPs.bTabStopFiltros = false;
            this.uctrlTablaConFiltroREPs.DataSource = null;
            this.uctrlTablaConFiltroREPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroREPs.dtrAgregarFila = null;
            this.uctrlTablaConFiltroREPs.Location = new System.Drawing.Point(3, 16);
            this.uctrlTablaConFiltroREPs.Name = "uctrlTablaConFiltroREPs";
            this.uctrlTablaConFiltroREPs.Size = new System.Drawing.Size(807, 215);
            this.uctrlTablaConFiltroREPs.TabIndex = 15;
            this.uctrlTablaConFiltroREPs.GridDatos_DoubleClick += new SistemaIkor.uctrlTablaConFiltro.GridDatos_DoubleClickEventHandler(this.uctrlTablaConFiltroREPs_GridDatos_DoubleClick);
            // 
            // frmEliminaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEliminaReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Elimina Reporte";
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDREP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbAgregarBD;
        public System.Windows.Forms.ToolStripButton tsbLimpiarPantalla;
        public System.Windows.Forms.ToolStripButton tsbProbarConn;
        public System.Windows.Forms.ToolStripButton tsbEliminarBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton tsbEliminaRep;
        public System.Windows.Forms.ToolStripButton tsbLimpiaPantalla;
        private System.Windows.Forms.GroupBox groupBox2;
        private uctrlTablaConFiltro uctrlTablaConFiltroREPs;
    }
}