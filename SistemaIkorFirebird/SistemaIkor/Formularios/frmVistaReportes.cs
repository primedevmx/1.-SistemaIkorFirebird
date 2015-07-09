using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Win32;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace SistemaIkor.Formularios
{
    public partial class frmVistaReportes : Form
    {
        #region PROPIEDADES
        DataSet _dsLoad = new DataSet();
        DataTable _dtREPORTE;
        DataTable _dtMAIN;
        Clases.mSeguridad _mSecurity = new Clases.mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmVistaReportes()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void frmVistaReportes_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmVistaReportes_KeyDown);
            vCargarInformacion();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            DataSet dsTemp = new DataSet();
            DataTable dtTemp = (DataTable)uctrlTablaConFiltroReporteSalida.gridDatos.DataSource;

            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                dsTemp.Tables.Add(dtTemp.Copy());
            }
            else
            {
                MessageBox.Show("Antes de Exportar a [Excel], necesita generar una búsqueda... ", "Mensaje"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int size = -1;

            saveFileDialog1.Filter =
                "Excel|*.xls|Excel 2010|*.xlsx";
            saveFileDialog1.Title = "Seleccione la ubicación del archivo";
            saveFileDialog1.FilterIndex = 1;

            DialogResult result = saveFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;
                try
                {

                    if (CrearExcel_DS(dsTemp, file) == "EXITO")
                    {

                        MessageBox.Show("Se ha Generado correctamente el archivo de Excel en la siguiente ruta: \n\r" +
                            file ,"Mensaje del Sistema" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else {
                        MessageBox.Show("Ocurrió un problema a generar el archivo de Excel");
                                            
                    }

                }
                catch
                {
                    MessageBox.Show("Ocurrió un problema a generar el archivo de Excel");
                }
            }
        }

        private void tsbInfo_Click(object sender, EventArgs e)
        {
            Process pr = new Process();

            try
            {

                pr.StartInfo.FileName = Application.StartupPath + "\\Resources\\manual.pdf";

                pr.Start();

            }

            catch (NullReferenceException ex)
            {

                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void cmbBDs_SelectedValueChanged(object sender, EventArgs e)
        {
            uctrlTablaConFiltroReporteSalida.DataSource = null;

            if (cmbBDs.SelectedValue != null && Convert.ToInt32(cmbBDs.SelectedValue) > 0)
            {
                _dtREPORTE = _mSecurity.dtObtieneConsultaReportes(_mSecurity.strConnFB, cmbBDs.SelectedValue.ToString().Trim()).Copy();
                if (_dtREPORTE != null && _dtREPORTE.Rows.Count > 0)
                {
                    cmbNombreReporte.DisplayMember = _dtREPORTE.Columns[1].ColumnName.Trim();
                    cmbNombreReporte.ValueMember = _dtREPORTE.Columns[0].ColumnName.Trim();
                    cmbNombreReporte.DataSource = _dtREPORTE.Copy();
                    cmbNombreReporte.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("La Base de Datos Seleccionada [No Tiene Reportes Registrados]. \n - "+
                    "Por favor verifique.", "Atención"
                                          , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbNombreReporte.DataSource = null;                
                }
            }
        }

        private void tsbGeneraReporte_Click(object sender, EventArgs e)
        {
            //Salidadel Reporte->>
            _dtMAIN = new DataTable("CONSULTA_DEL_REPORTE");
            DataTable dtTemp = new DataTable();
                                 
            string str_CONN_STR = "";
            string str_SELECT_REP = "";
    
            //Previa Verificación->>
            string strErr;
            if (!bVerificaInfo(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserControls.SplashScreenFormV2 FRMSPLSH
              = new UserControls.SplashScreenFormV2("Obteniendo información del sistema... ", "Espere un momento por favor... ");
            FRMSPLSH.Show();
            FRMSPLSH.Refresh();

            try
            {

                DataTable dtTempReporte = _dtREPORTE.Select("IDREP=" + cmbNombreReporte.SelectedValue.ToString()).CopyToDataTable();
                if(dtTempReporte.Rows.Count > 0)
                {
                    DataTable dtTempConnString = _dsLoad.Tables[0].Select("[BD ->> ID]=" + dtTempReporte.Rows[0][3].ToString()).CopyToDataTable();
                    
                    //Consulta->>
                    _dtMAIN = _mSecurity.dtConsultaReportes(dtTempConnString.Rows[0][7].ToString(), dtTempReporte.Rows[0][2].ToString());
                    if (_dtMAIN.Rows.Count > -1)
                    {
                        FRMSPLSH.Close();
                        FRMSPLSH.Dispose();

                        //Extendida->>                     
                        string strFechaINI = dtpFechaIni.Value.ToShortDateString();
                        string strFechaFIN = dtpFechaFin.Value.ToShortDateString();
                        string strNoOrder = txtNoOrden.Text.Trim();                                            

                        //=================
                        //Orden y Fechas->>
                        //=================
                        if (chkNoOrden.Checked && chkFechas.Checked)
                        {              
                            //Previa Validación->>
                            string strErro;
                            //Orden->>
                            if (!bContieneOrden(_dtMAIN,out strErro))
                            {
                                MessageBox.Show(strErr, "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            //Fecha->>
                            if (!bContieneFecha(_dtMAIN, out strErro))
                            {
                                MessageBox.Show(strErr, "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            //Datos->>
                            if (strNoOrder.Length == 0)
                            {
                                MessageBox.Show("Favor de Escribir un [No de Orden].", "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                            try
                            {
                                dtTemp = _dtMAIN.Select("NUM_PINWIN = " + strNoOrder + " AND FECHA >= '" + strFechaINI + "' AND FECHA <= '" + strFechaFIN + "'"
                                    ).CopyToDataTable();
                            }
                            catch {
                                dtTemp = null;
                            }
                        }

                        //========                       
                        //Orden->>
                        //========
                        else if(chkNoOrden.Checked)
                        {
                            //Orden->>
                            string strErro;
                            if (!bContieneOrden(_dtMAIN, out strErro))
                            {
                                MessageBox.Show(strErro, "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (strNoOrder.Length > 0)
                            {
                                try
                                {
                                    dtTemp = _dtMAIN.Select("NUM_PINWIN = " + strNoOrder ).CopyToDataTable();
                                }
                                catch
                                {
                                    dtTemp = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Favor de Escribir un [No de Orden].", "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        //=========
                        //Fechas->>
                        //=========
                        else if (chkFechas.Checked)
                        {
                            //Fecha->>
                            string strErro;
                            if (!bContieneFecha(_dtMAIN, out strErro))
                            {
                                MessageBox.Show(strErr, "Verificar Datos"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                            try
                            {
                                dtTemp = _dtMAIN.Select("FECHA >= '" + strFechaINI + "' AND FECHA <= '" + strFechaFIN + "'").CopyToDataTable();
                            }
                            catch {
                                dtTemp = null;
                            }
                        }

                        //===============                        
                        //No Extendida->>
                        //===============
                        else
                        {
                            dtTemp = _dtMAIN.Copy();                             
                        }                     

                        //Entrega Resultado->>
                        if (dtTemp != null)
                        {
                            uctrlTablaConFiltroReporteSalida.DataSource = dtTemp.Copy();
                            MessageBox.Show("Operación realizada satisfactoriamente. \n\r - Puede usted continuar."
                            , "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            uctrlTablaConFiltroReporteSalida.DataSource = null;
                            MessageBox.Show("Filtro executado satisfactoriamente. \n\r - Puede usted continuar."
                            , "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        if (_dtMAIN.Rows.Count == 0)
                        {
                            MessageBox.Show("Favor de verificar los parámetros de filtro del reporte. \n\r - La base de datos Interbase no distingue entre [mayusc y minusc]."+
                                "\n\r \n\r - Consulte con su administrador del sistema."
                               , "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            
            }
            catch(Exception EX) {
                string strSalida = EX.Message + "\r\n \r\n - No se ha establecido la conexión correctamente."
                            + " \r\n \r\n ";
                MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN CON LA BD SELECCIONADA-"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

            FRMSPLSH.Close();
            FRMSPLSH.Dispose();

        }

        private void frmVistaReportes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                tsbGeneraReporte_Click(null,null);
            }
            if (e.KeyCode.ToString() == "F2")
            {
                tsbExcel_Click(null, null);
            }
        }

        private void chkExtend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechas.Checked)
            {
                dtpFechaFin.Enabled = true;
                dtpFechaIni.Enabled = true;
            }
            else {
                dtpFechaFin.Enabled = false;
                dtpFechaIni.Enabled = false;
                dtpFechaFin.Value = DateTime.Now;
                dtpFechaIni.Value = DateTime.Now;
            }
        }

        private void chkNoOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoOrden.Checked)
            {
                txtNoOrden.Enabled = true;
            }
            else
            {
                txtNoOrden.Enabled = false;
                txtNoOrden.Text = "";
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
                    this.cmbBDs.SelectedValueChanged -= new System.EventHandler(this.cmbBDs_SelectedValueChanged);
                    cmbBDs.DisplayMember = _dsLoad.Tables[0].Columns[6].ColumnName.Trim();
                    cmbBDs.ValueMember = _dsLoad.Tables[0].Columns[0].ColumnName.Trim();
                    cmbBDs.DataSource = _dsLoad.Tables[0].Copy();
                    cmbBDs.SelectedIndex = -1;
                    this.cmbBDs.SelectedValueChanged += new System.EventHandler(this.cmbBDs_SelectedValueChanged);
                    chkFechas.Checked = false;
                    chkExtend_CheckedChanged(null,null);
                    chkNoOrden.Checked = false;
                    chkNoOrden_CheckedChanged(null, null);

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("Connect BD Fail: \n - " + EX.Message, "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        
        }
        private bool bVerificaInfo(out string err)
        {
            err = "";
            if (cmbBDs.Text == "") { err = "Debe Especificar la Base de Datos del Reporte."; }
            else if (cmbNombreReporte.Text == "") { err = "Debe Especificar el [Nombre del Reporte] de la Base de Datos."; }
            else if (_dtREPORTE == null) { err = "Seleccione nuevamente el reporte que desea generar."; }

            return (err == "");
        }

        private bool bContieneFecha(DataTable table, out string err)
        {
            err = "";

            if (!table.Columns.Contains("FECHA"))
            {
                 err = "El Reporte seleccionado no cuenta con el parámetro de [FECHA], por favor verifique.";
            }

            return (err == "");
                   
        }

        private bool bContieneOrden(DataTable table, out string err)
        {
            err = "";

            if (!table.Columns.Contains("NUM_PINWIN"))
            {
                err = "El Reporte seleccionado no cuenta con el parámetro de [NUM_PINWIN], por favor verifique.";
            }

            return (err == "");

        }

        public string CrearExcel_DS(DataSet DS, string strFile)
        {
            #region CREACION DE VARIABLES
            Excel.Application eAplicacion = new Excel.Application();
            Excel.Workbook eLibro = null;
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            #endregion
            #region CUERPO
            try
            {
                #region Crear Libro
                try { eLibro = eAplicacion.Workbooks.Add(System.Reflection.Missing.Value); }
                catch
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    eLibro = eAplicacion.Workbooks.Add(System.Reflection.Missing.Value);
                }
                #endregion
                #region Crear Hojas
                foreach (DataTable dtbHoja in DS.Tables)
                {
                    int intColumnas = dtbHoja.Columns.Count;
                    #region HOJA Excel
                    Excel.Worksheet eHoja = DS.Tables.IndexOf(dtbHoja) < 3 ?
                        (Excel.Worksheet)eAplicacion.Sheets[DS.Tables.IndexOf(dtbHoja) + 1] :
                        (Excel.Worksheet)eAplicacion.Sheets.Add(eAplicacion.Sheets[DS.Tables.IndexOf(dtbHoja)], Type.Missing, Type.Missing, Type.Missing);
                    eHoja.Name = dtbHoja.TableName;

                    Excel.Range rCeldas = eHoja.Cells[1, 1];

                    Excel.Range rRango = eHoja.UsedRange; ;
                    
                    #region COLUMNAS
                    rRango = rCeldas[1, 1];
                    for (int i = 0; i < dtbHoja.Columns.Count; i++)
                        eHoja.Cells[1, 1 + i] = dtbHoja.Columns[i].ColumnName;
                    #endregion
                    #region LLENDO DE FILAS
                    int intFila = 2;
                    int intValor = 0;
                    foreach (DataRow dtrDatos in dtbHoja.Rows)
                    {
                        //rRango = (Excel.Range)rCeldas.get_Range(rCeldas[intFila, 1], rCeldas[intFila, dtbHoja.Columns.Count]);
                        rRango = rCeldas[intFila, dtbHoja.Columns.Count];

                        for (int i = 0; i < dtbHoja.Columns.Count; i++)
                            eHoja.Cells[intFila, 1 + i] = Int32.TryParse(dtrDatos[dtbHoja.Columns[i]].ToString(), out intValor) ?
                                intValor.ToString() : (dtrDatos[dtbHoja.Columns[i]].ToString().Contains("'") ?
                                dtrDatos[dtbHoja.Columns[i]].ToString() : "'" + dtrDatos[dtbHoja.Columns[i]].ToString());
                        intFila++;
                    }
                    #endregion
                    #endregion
                }
                #endregion
                #region GUARDAR EXCEL
                eAplicacion.DisplayAlerts = false;
                eLibro.SaveAs(strFile,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value);
                #endregion
                return "EXITO";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                #region CERRAR LIBRO
                if (eLibro != null)
                    eLibro.Close(false, null, null);
                eAplicacion.Quit();
                System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI;
                #endregion
            }
            #endregion
        }    
        #endregion METODOS
    }
}
