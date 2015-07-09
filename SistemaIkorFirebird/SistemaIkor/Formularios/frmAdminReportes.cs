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
    public partial class frmAdminReportes : Form
    {
        #region PROPIEDADES
        DataSet _dsLoad;
        bool _bload = true;
        bool _bDB = false;
        Clases.mSeguridad _mSecurity = new Clases.mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmAdminReportes()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void frmAdminReportes_Load(object sender, EventArgs e)
        {
            vCargarInformacion();
            _bload = false;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGuardarReporte_Click(object sender, EventArgs e)
        {
            DataSet dsReps = new DataSet();
            DataTable dtTEMP = new DataTable();
            //Previa Verificación->>
            string strErr;
            if (!bVerificaInfo(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strSalida = "";
            string strSelect = "SELECT * FROM " + cmbTBS.Text.Trim();
            int intCounter = 0;
            

            try
            {
                try
                {
                    //OBTIENE CONSULTA->>
                    if (uctrlTablaConFiltroReporte.Filtro.Count > 0)
                    {

                        foreach (KeyValuePair<string, string> Par in uctrlTablaConFiltroReporte.Filtro)
                        {
                            if (intCounter == 0)
                            {
                                strSelect += " WHERE cast( " + Par.Key + " as varchar(1024) )  like  \"" + Par.Value + "\"   ";
                            }
                            else 
                            {
                                strSelect += " AND cast( " + Par.Key + " as varchar(1024) )  like    \"" + Par.Value + "\"   ";
                            }

                            intCounter++;
                        } 

                    }


                    dtTEMP = _dsLoad.Tables[0].Select("[BD ->> ID] = " + cmbBDS.SelectedValue.ToString().Trim()).CopyToDataTable();
                    
                    //GUARDAR_REP->>
                    dsReps = _mSecurity.dsGuardarReporte(
                                    _mSecurity.strConnFB                     //ConnString<<-
                                ,   dtTEMP.Rows[0][0].ToString().Trim()      //idBD<<-
                                ,   strSelect                                   //Consulta<<-
                                ,   txtNombreReporte.Text.Trim()            //NombreRep<<-
                        
                        );

                    if (dsReps != null && dsReps.Tables[0].Rows.Count > 0)
                    {
                        //SALIDA->>
                        MessageBox.Show("Operación realizada satisfactoriamente. \n - Puede usted continuar.", "Mensaje del Sistema"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vLimpiarDatos();
                    }

                }
                catch (Exception EX)
                {
                    cmbTBS.DataSource = null;
                    if (!_bload )
                    {
                        strSalida = EX.Message + "\r\n \r\n - No se ha establecido la conexión correctamente."
                        + " \r\n \r\n - Verifique la configuración de los parámetros del servidor de la BD.";
                        MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN CON LA BD SELECCIONADA-"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch { }
        }

        private void cmbTBS_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dtTBs = new DataTable();
            DataTable dtTEMP = new DataTable();
            Cursor.Current = Cursors.WaitCursor;
            string strSalida = "";

            UserControls.SplashScreenFormV2 FRMSPLSH
                = new UserControls.SplashScreenFormV2("Obteniendo información del sistema... ", "Espere un momento por favor... ");
            FRMSPLSH.Show();
            FRMSPLSH.Refresh();

            try
            {
                try
                {
                        dtTEMP = _dsLoad.Tables[0].Select("[BD ->> ID] = " + cmbBDS.SelectedValue.ToString().Trim()).CopyToDataTable();
                        dtTBs = _mSecurity.dtObtieneConsultaTabla(dtTEMP.Rows[0][7].ToString().Trim(), cmbTBS.Text.Trim());

                        if (dtTBs != null && dtTBs.Rows.Count > 0)
                        {
                            //Llena uctrl->>
                            uctrlTablaConFiltroReporte.DataSource = dtTBs.Copy();
                            #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                            //this.uctrlTablaConFiltroReporte.gridDatos.SelectionMode =
                            //DataGridViewSelectionMode.FullRowSelect;
                            //this.uctrlTablaConFiltroReporte.gridDatos.MultiSelect = false;
                            #endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                            //Desactivar el SortMode
                            foreach (DataGridViewColumn columna in uctrlTablaConFiltroReporte.gridDatos.Columns)
                            {
                                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                            Cursor.Current = Cursors.Arrow;

                        }

                        FRMSPLSH.Close();
                        FRMSPLSH.Dispose();

                }
                catch (Exception EX)
                {
                    cmbTBS.DataSource = null;
                    if (!_bload)
                    {
                        strSalida = EX.Message + "\r\n \r\n - No se ha establecido la conexión correctamente."
                        + " \r\n \r\n - Verifique la configuración de los parámetros del servidor de la BD.";
                        MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN CON LA BD SELECCIONADA-"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch { }
        }

        private void tsbSeleccionaREP_Click(object sender, EventArgs e)
        {
            //Previa Verificación->>
            string strErr;
            if (!bVerificaInfo2(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //frmConsulta->>
            UserControls.frmConsulta _FRMCONN = new UserControls.frmConsulta(0);
            _FRMCONN.StartPosition = FormStartPosition.CenterScreen;
            _FRMCONN.bLeeItem = true;
            _FRMCONN.Text = "- Reportes del Usuario del Sistema";
            _FRMCONN.Seleccionar.Text = "- Reportes del Usuario del Sistema -   ";
            _FRMCONN.Size = new System.Drawing.Size(800, 400);
            _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            DataTable dtTemp =  _mSecurity.dtObtieneConsultaReportes(_mSecurity.strConnFB, cmbBDS.SelectedValue.ToString().Trim()).Copy();
            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                _FRMCONN.dt = dtTemp.Copy();
                _FRMCONN.Show();
            }
            else {
                MessageBox.Show("La [Base de datos Seleccionada] no cuenta con reportes. \n - Por favor verifique. ","Mensaje del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);          
            
            }
            

        }

        private void cmbBDS_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dtTBs = new DataTable();
            DataTable dtTEMP = new DataTable();
            string strSalida = "";
            try
            {
                try
                {
                    dtTEMP = _dsLoad.Tables[0].Select("[BD ->> ID] = "+cmbBDS.SelectedValue.ToString().Trim()).CopyToDataTable();
                    dtTBs = _mSecurity.dsObtieneTablasBD(dtTEMP.Rows[0][7].ToString().Trim()).Tables[0];

                    if (dtTBs.Rows.Count > 0)
                    {
                        //Llena Combo TBs->>
                        this.cmbTBS.SelectedValueChanged -= new System.EventHandler(this.cmbTBS_SelectedValueChanged);
                        cmbTBS.DataSource = dtTBs.Copy();
                        cmbTBS.DisplayMember = dtTBs.Columns[0].ColumnName.Trim();
                        cmbTBS.SelectedIndex = -1;
                        this.cmbTBS.SelectedValueChanged += new System.EventHandler(this.cmbTBS_SelectedValueChanged);
                        uctrlTablaConFiltroReporte.DataSource = null;
                        tsbSeleccionaREP.Text = "Consultar Reportes BD->> "+dtTEMP.Rows[0][6].ToString().Trim();
                        tsbEliminaRep.Text = "Eliminar Reportes BD ->> " + dtTEMP.Rows[0][6].ToString().Trim() ;
                        TSL_TITTLE.Text = " Administración de reportes   ->> " + dtTEMP.Rows[0][6].ToString().Trim();
                    }
                 
                }
                catch(Exception EX) {
                    cmbTBS.DataSource = null;
                    if (!_bload)
                    {
                        strSalida = EX.Message + "\r\n \r\n - No se ha establecido la conexión correctamente." 
                        + " \r\n \r\n - Verifique la configuración de los parámetros del servidor de la BD.";
                        MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN CON LA BD SELECCIONADA-"
                            ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        tsbSeleccionaREP.Text = "Consultar Reportes BD";
                        tsbEliminaRep.Text = "Eliminar Reportes";
                        TSL_TITTLE.Text = " Administración de reportes ";

                    }
                   }


            }
            catch { }
        }

        private void tsbEliminaRep_Click(object sender, EventArgs e)
        {
            //Previa Verificación->>
            string strErr;
            if (!bVerificaInfo2(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Mostrar Forma->>
            DataTable dtTemp = _mSecurity.dtObtieneConsultaReportes(_mSecurity.strConnFB, cmbBDS.SelectedValue.ToString().Trim()).Copy();
            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                frmEliminaReporte _FRMCONN = new frmEliminaReporte(dtTemp.Copy());
                _FRMCONN.ShowDialog();
            }
            else
            {
                MessageBox.Show("La [Base de datos Seleccionada] no cuenta con reportes. \n - Por favor verifique. ", "Mensaje del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        #endregion EVENTOS
        #region METODOS
        private void vCargarInformacion()
        {
            _dsLoad = new DataSet();
            try
            {
                _dsLoad = _mSecurity.dsObtenerConfiguraBDs();

                if (_dsLoad.Tables[0].Rows.Count > 0)
                {
                    cmbBDS.DisplayMember = _dsLoad.Tables[0].Columns[6].ColumnName.Trim();
                    cmbBDS.ValueMember = _dsLoad.Tables[0].Columns[0].ColumnName.Trim();
                    cmbBDS.DataSource = _dsLoad.Tables[0].Copy();
                    cmbBDS.SelectedIndex = -1;
                    tsbSeleccionaREP.Text = "Consultar Reportes BD";
                    tsbEliminaRep.Text = "Eliminar Reportes";
                    TSL_TITTLE.Text = " Administración de reportes ";
                
                }

            }
            catch (Exception EX){
                MessageBox.Show("Connect BD Fail: \n - " + EX.Message, "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }
        private bool bVerificaInfo(out string err)
        {
            err = "";
            //Datos Nacimiento
            if (cmbBDS.Text == "") { err = "Debe Especificar la Base de Datos del Reporte."; }
            else if (cmbTBS.Text == "") { err = "Debe Especificar la [Tabla] de la Base de Datos."; }
            else if (txtNombreReporte.Text == "") { err = "Debe Especificar el [Nombre del Reporte] de la Base de Datos y en su defecto determinar un filtro a la consulta."; }

            return (err == "");
        }
        private bool bVerificaInfo2(out string err)
        {
            err = "";
            //Datos Nacimiento
            if (cmbBDS.Text == "") { err = "Debe Especificar la Base de Datos de los Reporte."; }

            return (err == "");
        }
        private bool bquitaComita(string strCadena)
        {
           //Verifica Tipo Dato->>
            double retNum;
            if (Double.TryParse(Convert.ToString(strCadena), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum))
            {
                return true;
            }
          
            else
                return false;

        }
        private void vLimpiarDatos()
        {
            uctrlTablaConFiltroReporte.DataSource = null;
            txtNombreReporte.Text = "";
        }
        #endregion METODOS   
    }
}
