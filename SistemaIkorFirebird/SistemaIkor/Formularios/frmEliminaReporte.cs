using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaIkor.Formularios
{

    public partial class frmEliminaReporte : Form
    {
        #region PROPIEDADES
        DataTable _dtEliminaREP;
        DataRow _drSelectedRO = null;
        int _intID_BD = 0;
        Clases.mSeguridad _mSecurity = new Clases.mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmEliminaReporte()
        {
            InitializeComponent();
        }
        public frmEliminaReporte(DataTable dtEliminaREP)
        {
            InitializeComponent();
            _dtEliminaREP = dtEliminaREP;
            uctrlTablaConFiltroREPs.DataSource = _dtEliminaREP;
            _intID_BD = Convert.ToInt32(_dtEliminaREP.Rows[0][3]);
            #region AJUSTE AL GRID
            #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
            uctrlTablaConFiltroREPs.gridDatos.SelectionMode =
			DataGridViewSelectionMode.FullRowSelect;
			uctrlTablaConFiltroREPs.gridDatos.MultiSelect = false;
			#endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
            //Desactivar el SortMode
            foreach (DataGridViewColumn columna in uctrlTablaConFiltroREPs.gridDatos.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            uctrlTablaConFiltroREPs.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uctrlTablaConFiltroREPs.toolBusqueda.Visible = false;
            #endregion AJUSTE AL GRID
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsbEliminaRep_Click(object sender, EventArgs e)
        {
            DataSet dsElimina = new DataSet();
            //Previa Validación->>
            if (_drSelectedRO == null)
            {
                MessageBox.Show("Favor de Seleccionar un Reporte a [Eliminar]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Proceso->>            
            if (MessageBox.Show("¿Esta seguro de eliminar el reporte?. \n - Esta operación eliminará su reporte de la BD.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    dsElimina = _mSecurity.dsEliminaRep(_drSelectedRO[0].ToString());

                    //Salida->>
                    if (dsElimina.Tables[0].Rows.Count > 0)
                    {
                        tsbLimpiaPantalla_Click(null, null);
                        MessageBox.Show("Operación realizada satisfactoriamente. \n\r \n\r - Puede usted continuar."
                            , "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Ocurrió un error inesperado; \n\r" + EX.Message + "\n\r \n\r - Por favor verifique."
                               , "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void uctrlTablaConFiltroREPs_GridDatos_DoubleClick(object sender, uctrlTablaConFiltro.GridDatos_DoubleClickEnventArgs e)
        {
            _drSelectedRO = ((DataRowView)uctrlTablaConFiltroREPs.gridDatos.CurrentRow.DataBoundItem).Row;

            if (_drSelectedRO != null)
            {
                txtIDREP.Text = _drSelectedRO[0].ToString();
                txtNombreRep.Text = _drSelectedRO[1].ToString();
                txtNombreBD.Text = _drSelectedRO[4].ToString(); ;
            }

        }

        private void tsbLimpiaPantalla_Click(object sender, EventArgs e)
        {
            _drSelectedRO = null;
            txtIDREP.Text = "";
            txtNombreRep.Text = "";
            txtNombreBD.Text = "";
            vCargarDatos();
        }

        #endregion EVENTOS
        #region METODOS
        void vCargarDatos()
        {
            DataTable dtTemp = _mSecurity.dtObtieneConsultaReportes(_mSecurity.strConnFB, _intID_BD.ToString().Trim()).Copy();
            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                uctrlTablaConFiltroREPs.DataSource = dtTemp.Copy();
                uctrlTablaConFiltroREPs.toolBusqueda.Visible = false;
                #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                this.uctrlTablaConFiltroREPs.gridDatos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                this.uctrlTablaConFiltroREPs.gridDatos.MultiSelect = false;
                #endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                //Desactivar el SortMode
                foreach (DataGridViewColumn columna in uctrlTablaConFiltroREPs.gridDatos.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            else
            {
                MessageBox.Show("La [Base de datos Seleccionada] no cuenta con reportes. \n - Por favor verifique. ", "Mensaje del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion METODOS
    }

}
