namespace SistemaIkor
{
    partial class frmMenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicio));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbVerRep = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVerRep});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(244, 512);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbVerRep
            // 
            this.tsbVerRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVerRep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbVerRep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbVerRep.Image = ((System.Drawing.Image)(resources.GetObject("tsbVerRep.Image")));
            this.tsbVerRep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVerRep.Name = "tsbVerRep";
            this.tsbVerRep.Size = new System.Drawing.Size(242, 19);
            this.tsbVerRep.Text = " - Visualizar Reportes";
            this.tsbVerRep.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbVerRep.Click += new System.EventHandler(this.tsbVerRep_Click);
            // 
            // frmMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(244, 512);
            this.Controls.Add(this.toolStrip3);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuInicio";
            this.Opacity = 0.75D;
            this.TabText = "Inicio";
            this.Text = "Ingrese a su actividad";
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbVerRep;
    }
}