namespace SistemaIkor.UserControls
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.pnlAccion = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Seleccionar = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.GrdDatos = new SistemaIkor.uctrlTablaConFiltro();
            this.tspMensaje = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlAccion.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.tspMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccion
            // 
            this.pnlAccion.Controls.Add(this.toolStrip2);
            this.pnlAccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccion.Location = new System.Drawing.Point(0, 0);
            this.pnlAccion.Name = "pnlAccion";
            this.pnlAccion.Size = new System.Drawing.Size(623, 46);
            this.pnlAccion.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue1;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Seleccionar,
            this.Cancelar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(623, 46);
            this.toolStrip2.TabIndex = 33;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            // 
            // Seleccionar
            // 
            this.Seleccionar.BackColor = System.Drawing.Color.Transparent;
            this.Seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Seleccionar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccionar.ForeColor = System.Drawing.Color.White;
            this.Seleccionar.Image = global::SistemaIkor.Properties.Resources.View_Details_32;
            this.Seleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(111, 43);
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Cancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Image = global::SistemaIkor.Properties.Resources.delete_26;
            this.Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(74, 43);
            this.Cancelar.Text = "Cerrar";
            this.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.GrdDatos);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 46);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(623, 317);
            this.pnlGrid.TabIndex = 1;
            // 
            // GrdDatos
            // 
            this.GrdDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrdDatos.bContador = true;
            this.GrdDatos.bFiltro = true;
            this.GrdDatos.bMostrarGrip = true;
            this.GrdDatos.bTabStopFiltros = false;
            this.GrdDatos.DataSource = null;
            this.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDatos.dtrAgregarFila = null;
            this.GrdDatos.Location = new System.Drawing.Point(0, 0);
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.Size = new System.Drawing.Size(623, 317);
            this.GrdDatos.TabIndex = 0;
            this.GrdDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            // 
            // tspMensaje
            // 
            this.tspMensaje.BackgroundImage = global::SistemaIkor.Properties.Resources.bgBlue1;
            this.tspMensaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspMensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.tspMensaje.Location = new System.Drawing.Point(0, 338);
            this.tspMensaje.Name = "tspMensaje";
            this.tspMensaje.Size = new System.Drawing.Size(623, 25);
            this.tspMensaje.TabIndex = 1;
            this.tspMensaje.Text = ".: Selecciona las diferentes opciones manteniendo presionada la tecla Control (CT" +
    "RL) :.";
            this.tspMensaje.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(461, 22);
            this.toolStripLabel1.Text = ".: Selecciona las diferentes opciones manteniendo presionada la tecla Control (CT" +
    "RL) :.";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAccion);
            this.Controls.Add(this.tspMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.Text = " Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            this.pnlAccion.ResumeLayout(false);
            this.pnlAccion.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.tspMensaje.ResumeLayout(false);
            this.tspMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccion;
        private System.Windows.Forms.Panel pnlGrid;
        public SistemaIkor.uctrlTablaConFiltro GrdDatos;
        public System.Windows.Forms.ToolStripButton Seleccionar;
        public System.Windows.Forms.ToolStripButton Cancelar;
        public System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStrip tspMensaje;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}