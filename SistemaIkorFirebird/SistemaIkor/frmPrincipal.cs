using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

/// <summary>
/// Autor: 
///     Miguel Gutierrez Arroyo
/// Fecha: 
///     2014/05/06
/// 
/// Descripcion: 
///     Login de la Aplicacion
/// Acciones: 
///     Login
/// 
/// </summary> 
namespace SistemaIkor
{
    public partial class frmPrincipal : Form
    {
        #region PROPIEDADES
        frmMenuInicio menu;
        frmMenuConfiguracion menu2;
        Clases.mSeguridad _mSecurity;
        public int ProgressValue
        {
            set
            {
                toolStripProgressBar1.Value = value;
                if (value == 100)
                {
                    toolStripProgressBar1.Visible = false;
                }
                else
                {
                    toolStripProgressBar1.Visible = true;
                }
            }

        }

        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public frmPrincipal(Clases.mSeguridad mSec)
        {
            InitializeComponent();
            _mSecurity = mSec;
        }
        #endregion CONSTRUCTORES
        #region FUNCIONES
        private void vMostrarMenuInicio()
        {
            menu = new frmMenuInicio(this);
            menu.RightToLeftLayout = true;
            menu.Show(dockPanel1, DockState.DockLeftAutoHide);
        }

        private void vMostrarMenuConfiguracion()
        {
            menu2 = new frmMenuConfiguracion(this);
            menu2.RightToLeftLayout = true;
            menu2.Show(dockPanel1, DockState.DockLeftAutoHide);
        }

        #endregion FUNCIONES
        #region EVENTOS

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            stLabelStatus.Text = "Conectado : " + _mSecurity.strUsuarioSistema.ToLower(); ;

            vMostrarMenuInicio();
            
            //Solo Usuario Admin->
            if (_mSecurity.bUsuarioAdmin)
            {
                vMostrarMenuConfiguracion();
            }
            
            try
            {
                label2.Text += " " + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                label2.Text += " Desarrollo";
            }


            ProgressValue = 100;

        }

        private void mostrarMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vMostrarMenuInicio();

            //Solo Usuario Admin->
            if (_mSecurity.bUsuarioAdmin)
            {
                vMostrarMenuConfiguracion();
            }
        }

        private void dockPanel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void dockPanel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLOGG = new frmLogin();
            frmLOGG.ShowDialog();
        }
        #endregion EVENTOS
    }
}
