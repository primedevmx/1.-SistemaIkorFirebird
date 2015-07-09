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
    public partial class frmMenuInicio : ToolWindow
    {
        #region PROPIEDADES
        frmPrincipal mdipr;
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmMenuInicio(Form frmMDI)
        {
            mdipr = (frmPrincipal)frmMDI;
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region METODOS
        #endregion METODOS
        #region ACCESOS
        private void tsbVerRep_Click(object sender, EventArgs e)
        {
            Formularios.frmVistaReportes frm3 = new Formularios.frmVistaReportes();
            clSeguridad.vCargaForma(frm3, mdipr, "Visualizar Reportes");
            
        }       
        #endregion ACCESOS
    }
}