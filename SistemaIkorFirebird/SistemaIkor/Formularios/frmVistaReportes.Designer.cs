namespace SistemaIkor.Formularios
{
    partial class frmVistaReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaReportes));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroReporteSalida = new SistemaIkor.uctrlTablaConFiltro();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGeneraReporte = new System.Windows.Forms.ToolStripButton();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.chkNoOrden = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.gbxExtendida = new System.Windows.Forms.GroupBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNombreReporte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBDs = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tspTittle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxOrder.SuspendLayout();
            this.gbxExtendida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue1;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(791, 33);
            this.tspTittle.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(177, 30);
            this.toolStripLabel1.Text = "   Consulta de reportes  ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(30, 30);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.uctrlTablaConFiltroReporteSalida);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 384);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Si requiere generar filtros comparativos en su consulta, puede utilizar los signo" +
    "s [<>] en el campo de texto de la consulta ->>";
            // 
            // uctrlTablaConFiltroReporteSalida
            // 
            this.uctrlTablaConFiltroReporteSalida.bContador = true;
            this.uctrlTablaConFiltroReporteSalida.bFiltro = true;
            this.uctrlTablaConFiltroReporteSalida.bMostrarGrip = false;
            this.uctrlTablaConFiltroReporteSalida.bTabStopFiltros = false;
            this.uctrlTablaConFiltroReporteSalida.DataSource = null;
            this.uctrlTablaConFiltroReporteSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroReporteSalida.dtrAgregarFila = null;
            this.uctrlTablaConFiltroReporteSalida.Location = new System.Drawing.Point(3, 55);
            this.uctrlTablaConFiltroReporteSalida.Name = "uctrlTablaConFiltroReporteSalida";
            this.uctrlTablaConFiltroReporteSalida.Size = new System.Drawing.Size(785, 326);
            this.uctrlTablaConFiltroReporteSalida.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInfo,
            this.tsbGeneraReporte,
            this.toolStripSeparator1,
            this.tsbExcel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(785, 39);
            this.toolStrip1.TabIndex = 7;
            // 
            // tsbGeneraReporte
            // 
            this.tsbGeneraReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGeneraReporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGeneraReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbGeneraReporte.Image = global::SistemaIkor.Properties.Resources.engineering_32;
            this.tsbGeneraReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGeneraReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGeneraReporte.Name = "tsbGeneraReporte";
            this.tsbGeneraReporte.Size = new System.Drawing.Size(207, 36);
            this.tsbGeneraReporte.Text = " Genere su reporte <<-";
            this.tsbGeneraReporte.Click += new System.EventHandler(this.tsbGeneraReporte_Click);
            // 
            // tsbExcel
            // 
            this.tsbExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExcel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbExcel.Image = global::SistemaIkor.Properties.Resources.excel_32;
            this.tsbExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(75, 36);
            this.tsbExcel.Text = "Excel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbInfo
            // 
            this.tsbInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbInfo.Image = global::SistemaIkor.Properties.Resources.info_32;
            this.tsbInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(68, 36);
            this.tsbInfo.Text = "Info";
            this.tsbInfo.Click += new System.EventHandler(this.tsbInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gbxOrder);
            this.groupBox1.Controls.Add(this.gbxExtendida);
            this.groupBox1.Controls.Add(this.cmbNombreReporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBDs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 145);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescione la Tecla [F1] para Generar su Reporte  ->> Presione [F2] para descargar" +
    " su [EXCEL] ->>";
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.chkNoOrden);
            this.gbxOrder.Controls.Add(this.label4);
            this.gbxOrder.Controls.Add(this.txtNoOrden);
            this.gbxOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxOrder.Location = new System.Drawing.Point(3, 47);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(785, 43);
            this.gbxOrder.TabIndex = 22;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "                            ";
            // 
            // chkNoOrden
            // 
            this.chkNoOrden.AutoSize = true;
            this.chkNoOrden.Location = new System.Drawing.Point(15, -1);
            this.chkNoOrden.Name = "chkNoOrden";
            this.chkNoOrden.Size = new System.Drawing.Size(73, 17);
            this.chkNoOrden.TabIndex = 58;
            this.chkNoOrden.Text = "Orden ->>";
            this.chkNoOrden.UseVisualStyleBackColor = true;
            this.chkNoOrden.CheckedChanged += new System.EventHandler(this.chkNoOrden_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "No Orden";
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Location = new System.Drawing.Point(73, 16);
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(311, 20);
            this.txtNoOrden.TabIndex = 0;
            // 
            // gbxExtendida
            // 
            this.gbxExtendida.Controls.Add(this.chkFechas);
            this.gbxExtendida.Controls.Add(this.dtpFechaFin);
            this.gbxExtendida.Controls.Add(this.dtpFechaIni);
            this.gbxExtendida.Controls.Add(this.label2);
            this.gbxExtendida.Controls.Add(this.label1);
            this.gbxExtendida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxExtendida.Location = new System.Drawing.Point(3, 90);
            this.gbxExtendida.Name = "gbxExtendida";
            this.gbxExtendida.Size = new System.Drawing.Size(785, 52);
            this.gbxExtendida.TabIndex = 21;
            this.gbxExtendida.TabStop = false;
            this.gbxExtendida.Text = "                           ";
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Location = new System.Drawing.Point(17, -1);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(79, 17);
            this.chkFechas.TabIndex = 57;
            this.chkFechas.Text = "Fechas ->>";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkExtend_CheckedChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtpFechaFin.Location = new System.Drawing.Point(460, 19);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(305, 20);
            this.dtpFechaFin.TabIndex = 55;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtpFechaIni.Location = new System.Drawing.Point(84, 19);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(300, 20);
            this.dtpFechaIni.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Fecha Inicial";
            // 
            // cmbNombreReporte
            // 
            this.cmbNombreReporte.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbNombreReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreReporte.FormattingEnabled = true;
            this.cmbNombreReporte.Location = new System.Drawing.Point(515, 20);
            this.cmbNombreReporte.Name = "cmbNombreReporte";
            this.cmbNombreReporte.Size = new System.Drawing.Size(268, 21);
            this.cmbNombreReporte.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "->> Nombre del Reporte";
            // 
            // cmbBDs
            // 
            this.cmbBDs.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbBDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBDs.FormattingEnabled = true;
            this.cmbBDs.Location = new System.Drawing.Point(97, 20);
            this.cmbBDs.Name = "cmbBDs";
            this.cmbBDs.Size = new System.Drawing.Size(290, 21);
            this.cmbBDs.TabIndex = 10;
            this.cmbBDs.SelectedValueChanged += new System.EventHandler(this.cmbBDs_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "->> Base de Datos";
            // 
            // frmVistaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVistaReportes";
            this.Text = "Visualización  de Reportes";
            this.Load += new System.EventHandler(this.frmVistaReportes_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxOrder.ResumeLayout(false);
            this.gbxOrder.PerformLayout();
            this.gbxExtendida.ResumeLayout(false);
            this.gbxExtendida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private uctrlTablaConFiltro uctrlTablaConFiltroReporteSalida;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNombreReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBDs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsbGeneraReporte;
        private System.Windows.Forms.ToolStripButton tsbExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbxExtendida;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.CheckBox chkNoOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInfo;
    }
}