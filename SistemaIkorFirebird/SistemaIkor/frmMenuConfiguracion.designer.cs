namespace SistemaIkor
{
    partial class frmMenuConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuConfiguracion));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbAdmRep = new System.Windows.Forms.ToolStripButton();
            this.tsbParametrosApp = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip3.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.toolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdmRep,
            this.tsbParametrosApp});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(247, 512);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbAdmRep
            // 
            this.tsbAdmRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdmRep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAdmRep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbAdmRep.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdmRep.Image")));
            this.tsbAdmRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdmRep.Name = "tsbAdmRep";
            this.tsbAdmRep.Size = new System.Drawing.Size(245, 19);
            this.tsbAdmRep.Text = " - Administrar Reportes";
            this.tsbAdmRep.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbAdmRep.Click += new System.EventHandler(this.tsbAdmRep_Click);
            // 
            // tsbParametrosApp
            // 
            this.tsbParametrosApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbParametrosApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbParametrosApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbParametrosApp.Image = ((System.Drawing.Image)(resources.GetObject("tsbParametrosApp.Image")));
            this.tsbParametrosApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbParametrosApp.Name = "tsbParametrosApp";
            this.tsbParametrosApp.Size = new System.Drawing.Size(245, 19);
            this.tsbParametrosApp.Text = " - Parametros de la Aplicación";
            this.tsbParametrosApp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbParametrosApp.Click += new System.EventHandler(this.tsbParametrosApp_Click);
            // 
            // frmMenuConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 512);
            this.Controls.Add(this.toolStrip3);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuConfiguracion";
            this.Opacity = 0.75D;
            this.TabText = "Configuración";
            this.Text = "Ingrese a su actividad";
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbAdmRep;
        private System.Windows.Forms.ToolStripButton tsbParametrosApp;
    }
}