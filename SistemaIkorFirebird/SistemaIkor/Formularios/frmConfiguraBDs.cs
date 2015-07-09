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
    public partial class frmConfiguraBDs : Form
    {
        #region PROPIEDADES
        DataSet _dsLoad;
        DataRow _dROBDs = null;
        SistemaIkor.Clases.mSeguridad _mSecurity = new Clases.mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmConfiguraBDs()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void frmConfiguraBDs_Load(object sender, EventArgs e)
        {
            vCargarInformacion();
            uctrlTablaConFiltroBDs.toolBusqueda.Visible = false;

        }

        private void tsbProbarConn_Click(object sender, EventArgs e)
        {
            //Previa Validacion ->>
            string strConn = "";

            if (_dROBDs == null)
            {
                MessageBox.Show("Favor de Seleccionar una BD a [Probar Conexion]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            strConn = _dROBDs[7].ToString().Trim();

            frmTestConection FRMM = new frmTestConection(strConn, "["+_dROBDs[6].ToString().Trim().ToUpper()+"]");
            FRMM.ShowDialog();

        }

        private void uctrlTablaConFiltroBDs_GridDatos_DoubleClick(object sender, uctrlTablaConFiltro.GridDatos_DoubleClickEnventArgs e)
        {
            _dROBDs = ((DataRowView)uctrlTablaConFiltroBDs.gridDatos.CurrentRow.DataBoundItem).Row;

            if (_dROBDs != null)
            {
                //Asig de Valores->>
                tsbEliminarBD.Visible = true;
                tsbProbarConn.Visible = true;
                tsbAgregarBD.Visible = false;

                txtUserBD.Enabled = false;
                txtPasswodBD.Enabled = false;
                txtIP.Enabled = false;
                txtRuta.Enabled = false;
                txtNombreBD.Enabled = false;
                txtDescrip.Enabled = false;

                txtUserBD.Text = _dROBDs[1].ToString().Trim();
                txtPasswodBD.Text = _dROBDs[2].ToString().Trim();
                txtIP.Text = _dROBDs[3].ToString().Trim();
                txtRuta.Text = _dROBDs[4].ToString().Trim();
                txtNombreBD.Text = _dROBDs[5].ToString().Trim();
                txtDescrip.Text = _dROBDs[6].ToString().Trim(); 
            
            }
                                     
        }

        private void tsbAgregarBD_Click(object sender, EventArgs e)
        {
            DataSet dsAgregarBD = new DataSet();
            string strCCSS = "";

            //Previa Validacion->>       
            string strErr;
            if (!bVerificaInfo(out strErr))
            {
                MessageBox.Show(strErr, "Verificar Datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult _DR = MessageBox.Show("- ¿Está correcta la información?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            //Agrega BD->>
            strCCSS = strArmaCCSS();
            
            dsAgregarBD = _mSecurity.dsAgregaBD(txtUserBD.Text.Trim(), txtPasswodBD.Text.Trim(), txtIP.Text.Trim(),
                txtRuta.Text.Trim(), txtNombreBD.Text.Trim(), txtDescrip.Text.Trim(), strCCSS);
            
            if (dsAgregarBD != null && dsAgregarBD.Tables[0].Rows.Count > 0)
            {
                tsbLimpiarPantalla_Click(null,null);
                
                MessageBox.Show("Operación realizada satisfactoriamente. \n Se ha actualizado correctamente la BD. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor.Current = Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void tsbEliminarBD_Click(object sender, EventArgs e)
        {
            DataSet dsEliminarBD = new DataSet();

            //Previa Validacion ->>
            if (_dROBDs == null)
            {
                MessageBox.Show("Favor de Seleccionar una BD a [Eliminar]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult _DR = MessageBox.Show("- ¿Está seguro de [Eliminar] la BD?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            //Elimina->>
            dsEliminarBD = _mSecurity.dsEliminaBD(_dROBDs[0].ToString().Trim());

            if (dsEliminarBD  != null && dsEliminarBD.Tables[0].Rows.Count > 0)
            {
                tsbLimpiarPantalla_Click(null, null);

                MessageBox.Show("Operación realizada satisfactoriamente. \n Se ha eliminado correctamente la BD. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor.Current = Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void tsbtnActualizarBD_Click(object sender, EventArgs e)
        {
            //Previa Validacion ->>
            if (_dROBDs == null)
            {
                MessageBox.Show("Favor de Seleccionar una BD a [Eliminar]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void tsbLimpiarPantalla_Click(object sender, EventArgs e)
        {
            //Limpieza->>
            txtUserBD.Text = "";
            txtPasswodBD.Text = "";
            txtIP.Text = "";
            txtRuta.Text = "";
            txtNombreBD.Text = "";
            txtDescrip.Text = "";
            _dROBDs = null;

            txtUserBD.Enabled = true;
            txtPasswodBD.Enabled = true;
            txtIP.Enabled = true;
            txtRuta.Enabled = true;
            txtNombreBD.Enabled = true;
            txtDescrip.Enabled = true;

            tsbEliminarBD.Visible = false;
            tsbProbarConn.Visible = false;

            tsbAgregarBD.Visible = true;
            vCargarInformacion();

        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        #endregion EVENTOS
        #region METODOS
        private void vCargarInformacion()
        {
            _dsLoad = new DataSet();

            //Cargar Info-->
            _dsLoad = _mSecurity.dsObtenerConfiguraBDs();
            try
            {
                //BDS->>
                uctrlTablaConFiltroBDs.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                uctrlTablaConFiltroBDs.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                uctrlTablaConFiltroBDs.DataSource = _dsLoad.Tables[0].Copy();
                #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                this.uctrlTablaConFiltroBDs.gridDatos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                this.uctrlTablaConFiltroBDs.gridDatos.MultiSelect = false;
                #endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                //Desactivar el SortMode
                foreach (DataGridViewColumn columna in uctrlTablaConFiltroBDs.gridDatos.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                uctrlTablaConFiltroBDs.toolBusqueda.Visible = false;
                txtIP.Focus();

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
            //Datos Nacimiento
            if (txtUserBD.Text == "") { err = "Debe Especificar el [Usuario] de la Base de Datos."; }
            else if (txtPasswodBD.Text == "") { err = "Debe Especificar el [Password] de la Base de Datos."; }
            else if (txtIP.Text == "") { err = "Debe Especificar la [IP del Servidor] de la Base de Datos."; }
            else if (txtRuta.Text == "") { err = "Debe Especificar la [Ruta del Servidor] de la Base de Datos."; }
            else if (txtNombreBD.Text == "") { err = "Debe Especificar el [Nombre] de la Base de Datos."; }
            else if (txtDescrip.Text == "") { err = "Debe Especificar la [Descripcion] de la Base de Datos a Mostrar en el [Combo de Reportes]."; }
   


            return (err == "");
        }
        private string strArmaCCSS()
        {

            //Database= localhost : C:\\SistemaIkor\\DBSECURITYIKOR.GDB;
            //User_Name= sysdba; Password=masterkey

            string strRet = "";

            strRet = "Database=" + txtIP.Text.Trim() + ":" + txtRuta.Text.Trim() + "\\" + txtNombreBD.Text.Trim() + ";" +
                     "User_Name=" + txtUserBD.Text.Trim() + ";" +
                     "Password=" + txtPasswodBD.Text.Trim();

            return strRet;
        }

        #endregion METODOS
    }
}
