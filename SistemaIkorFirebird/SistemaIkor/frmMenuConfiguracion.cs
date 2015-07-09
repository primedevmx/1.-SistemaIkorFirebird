using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MdiTabStrip.Design;
using MdiTabStrip;

namespace SistemaIkor
{
    /// <summary>
    /// Autor: 
    ///     Miguel Gutierrez Arroyo
    /// Fecha: 
    ///     2014/05/06
    /// 
    /// Descripcion: 
    ///     Menu Dinámico de la Aplicación
    /// Acciones: 
    ///     Desplegar Modulos
    /// 
    /// </summary> 
    public partial class frmMenuConfiguracion : ToolWindow
    {
        #region PROPIEDADES
        frmPrincipal mdipr;
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmMenuConfiguracion(Form frmMDI)
        {
            mdipr = (frmPrincipal)frmMDI;
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region METODOS
        #endregion METODOS
        #region ACCESOS
        private void tsbAdmRep_Click(object sender, EventArgs e)
        {
            Formularios.frmAdminReportes frm1 = new Formularios.frmAdminReportes();
            clSeguridad.vCargaForma(frm1, mdipr, "Administrar Reportes");
        }
        private void tsbParametrosApp_Click(object sender, EventArgs e)
        {
            Formularios.frmParametrosApp frm2 = new Formularios.frmParametrosApp();
            clSeguridad.vCargaForma(frm2, mdipr, "Parametros de la Aplicación");
        }
        #endregion ACCESOS
    }
}