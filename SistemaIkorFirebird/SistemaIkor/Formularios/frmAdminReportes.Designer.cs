namespace SistemaIkor.Formularios
{
    partial class frmAdminReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminReportes));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.TSL_TITTLE = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTBS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBDS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroReporte = new SistemaIkor.uctrlTablaConFiltro();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarReporte = new System.Windows.Forms.Button();
            this.txtNombreReporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbEliminaRep = new System.Windows.Forms.ToolStripButton();
            this.tsbSeleccionaREP = new System.Windows.Forms.ToolStripButton();
            this.tspTittle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::SistemaIkor.Properties.Resources.bgDark2;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_TITTLE,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(988, 33);
            this.tspTittle.TabIndex = 0;
            // 
            // TSL_TITTLE
            // 
            this.TSL_TITTLE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_TITTLE.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSL_TITTLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TSL_TITTLE.Name = "TSL_TITTLE";
            this.TSL_TITTLE.Size = new System.Drawing.Size(212, 30);
            this.TSL_TITTLE.Text = " Administración de reportes ";
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
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbTBS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbBDS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "* Configuración";
            // 
            // cmbTBS
            // 
            this.cmbTBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBS.FormattingEnabled = true;
            this.cmbTBS.Location = new System.Drawing.Point(123, 53);
            this.cmbTBS.Name = "cmbTBS";
            this.cmbTBS.Size = new System.Drawing.Size(405, 21);
            this.cmbTBS.TabIndex = 10;
            this.cmbTBS.SelectedValueChanged += new System.EventHandler(this.cmbTBS_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "- Nombre de la Tabla";
            // 
            // cmbBDS
            // 
            this.cmbBDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBDS.FormattingEnabled = true;
            this.cmbBDS.Location = new System.Drawing.Point(100, 19);
            this.cmbBDS.Name = "cmbBDS";
            this.cmbBDS.Size = new System.Drawing.Size(428, 21);
            this.cmbBDS.TabIndex = 1;
            this.cmbBDS.SelectedValueChanged += new System.EventHandler(this.cmbBDS_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "- Base de Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 465);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "->> Recuerde que su BD [Interbase-2009] [NO DISTINGUE] entre [MAYUSCULAS Y MINUSC" +
    "ULAS]. Favor de escribir en los filtros [EXACTAMENTE] como se lee del reporte de" +
    " la consulta.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uctrlTablaConFiltroReporte);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(982, 407);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "->> Esta Consulta es   [IGUALATIVA = ]    NO    [COMPARATIVA <> ].   La comparaci" +
    "ón de [FECHAS] y [VALORES] puede realizarse desde la [Vista de Reportes].";
            // 
            // uctrlTablaConFiltroReporte
            // 
            this.uctrlTablaConFiltroReporte.bContador = true;
            this.uctrlTablaConFiltroReporte.bFiltro = true;
            this.uctrlTablaConFiltroReporte.bMostrarGrip = true;
            this.uctrlTablaConFiltroReporte.bTabStopFiltros = false;
            this.uctrlTablaConFiltroReporte.DataSource = null;
            this.uctrlTablaConFiltroReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroReporte.dtrAgregarFila = null;
            this.uctrlTablaConFiltroReporte.Location = new System.Drawing.Point(3, 16);
            this.uctrlTablaConFiltroReporte.Name = "uctrlTablaConFiltroReporte";
            this.uctrlTablaConFiltroReporte.Size = new System.Drawing.Size(976, 308);
            this.uctrlTablaConFiltroReporte.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnGuardarReporte);
            this.groupBox3.Controls.Add(this.txtNombreReporte);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(976, 80);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[Nombre del Reporte] a mostrar en el combo de la [Vista de Reportes]  al [Usuario" +
    " de Producción]  ->>";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SistemaIkor.Properties.Resources.approval_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(902, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 53);
            this.panel1.TabIndex = 85;
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReporte.Location = new System.Drawing.Point(700, 26);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(196, 38);
            this.btnGuardarReporte.TabIndex = 84;
            this.btnGuardarReporte.Text = "Guardar &Reporte";
            this.btnGuardarReporte.UseVisualStyleBackColor = false;
            this.btnGuardarReporte.Click += new System.EventHandler(this.btnGuardarReporte_Click);
            // 
            // txtNombreReporte
            // 
            this.txtNombreReporte.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreReporte.Location = new System.Drawing.Point(119, 34);
            this.txtNombreReporte.Name = "txtNombreReporte";
            this.txtNombreReporte.Size = new System.Drawing.Size(563, 20);
            this.txtNombreReporte.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "* Nombre del Reporte";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::SistemaIkor.Properties.Resources.bgDark2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbEliminaRep,
            this.tsbSeleccionaREP});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(982, 39);
            this.toolStrip1.TabIndex = 7;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(198, 36);
            this.toolStripLabel2.Text = "    ->> Filtrar Reporte <<- ";
            // 
            // tsbEliminaRep
            // 
            this.tsbEliminaRep.BackColor = System.Drawing.Color.Transparent;
            this.tsbEliminaRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbEliminaRep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEliminaRep.ForeColor = System.Drawing.Color.White;
            this.tsbEliminaRep.Image = global::SistemaIkor.Properties.Resources.delete_321;
            this.tsbEliminaRep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEliminaRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminaRep.Name = "tsbEliminaRep";
            this.tsbEliminaRep.Size = new System.Drawing.Size(150, 36);
            this.tsbEliminaRep.Text = "Eliminar Reportes";
            this.tsbEliminaRep.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEliminaRep.ToolTipText = "Consultar Reporte";
            this.tsbEliminaRep.Click += new System.EventHandler(this.tsbEliminaRep_Click);
            // 
            // tsbSeleccionaREP
            // 
            this.tsbSeleccionaREP.BackColor = System.Drawing.Color.Transparent;
            this.tsbSeleccionaREP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSeleccionaREP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSeleccionaREP.ForeColor = System.Drawing.Color.White;
            this.tsbSeleccionaREP.Image = global::SistemaIkor.Properties.Resources.View_Details_32;
            this.tsbSeleccionaREP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSeleccionaREP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeleccionaREP.Name = "tsbSeleccionaREP";
            this.tsbSeleccionaREP.Size = new System.Drawing.Size(162, 36);
            this.tsbSeleccionaREP.Text = "Consultar Reportes";
            this.tsbSeleccionaREP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbSeleccionaREP.ToolTipText = "Consultar Reporte";
            this.tsbSeleccionaREP.Click += new System.EventHandler(this.tsbSeleccionaREP_Click);
            // 
            // frmAdminReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminReportes";
            this.Text = "Administración de Reportes";
            this.Load += new System.EventHandler(this.frmAdminReportes_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel TSL_TITTLE;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBDS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private uctrlTablaConFiltro uctrlTablaConFiltroReporte;
        private System.Windows.Forms.Button btnGuardarReporte;
        private System.Windows.Forms.TextBox txtNombreReporte;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripButton tsbSeleccionaREP;
        public System.Windows.Forms.ToolStripButton tsbEliminaRep;
        private System.Windows.Forms.Panel panel1;
    }
}