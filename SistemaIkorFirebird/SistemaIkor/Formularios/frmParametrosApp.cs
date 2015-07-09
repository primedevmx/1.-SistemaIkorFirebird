using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaIkor.Formularios
{
    public partial class frmParametrosApp : Form
    {
        #region CONSTRUCTORES
        public frmParametrosApp()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region PROPIEDADES
        Clases.mSeguridad _mSecurity = new Clases.mSeguridad();
        DataSet _dsLoad;
        #endregion PROPIEDADES
        #region EVENTOS
        private void frmParametrosApp_Load(object sender, EventArgs e)
        {
            //Load Info->>
            vCargarInformacion();
            uctrlTablaConFiltroBDs.toolBusqueda.Visible = false;
        }
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnActualizarCuentaAdmin_Click(object sender, EventArgs e)
        {
            DataSet dsActualizaCuentaAdmin = new DataSet ();
            //Previa Validacion->>
            DialogResult _DR = MessageBox.Show("- ¿Está correcta la información?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            //Actualiza Cuenta->>
            dsActualizaCuentaAdmin = _mSecurity.dsActualizarUsuario(txtAdminUser.Text.Trim(), txtAdminPass.Text.Trim());

            if (dsActualizaCuentaAdmin != null && dsActualizaCuentaAdmin.Tables[0].Rows.Count > 0)
            {
                vCargarInformacion();

                MessageBox.Show("Operación realizada satisfactoriamente.\n Se ha actualizado correctamente la cuenta administradora. \n - Puede usted continuar. ", "Mensaje del Sistema"
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
        private void btnActualizarCuentaProduc_Click(object sender, EventArgs e)
        {
            DataSet dsActualizaCuentaProduc = new DataSet();

            //Previa Validacion->>
            DialogResult _DR = MessageBox.Show("- ¿Está correcta la información?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            //Actualiza Cuenta->>
            dsActualizaCuentaProduc = _mSecurity.dsActualizarUsuario(txtProducUser.Text.Trim(), txtProducPass.Text.Trim());

            if (dsActualizaCuentaProduc != null && dsActualizaCuentaProduc.Tables[0].Rows.Count > 0)
            {
                vCargarInformacion();

                MessageBox.Show("Operación realizada satisfactoriamente. \n Se ha actualizado correctamente la cuenta de producción. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void tsbSeleccionarUsers_Click(object sender, EventArgs e)
        {
            //frmConsulta->>
            UserControls.frmConsulta _FRMCONN = new UserControls.frmConsulta(0);
            _FRMCONN.StartPosition = FormStartPosition.CenterScreen;
            _FRMCONN.bLeeItem = true;
            _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _FRMCONN.Text = "- Cuentas de Usuario del Sistema";
            _FRMCONN.Seleccionar.Text = "- Cuentas de Usuario del Sistema -   ";
            _FRMCONN.Size = new System.Drawing.Size(800, 400);
            _FRMCONN.dt = _dsLoad.Tables[0].Copy();
            _FRMCONN.Show();
        }
        private void tsbSeleccionarBDs_Click(object sender, EventArgs e)
        {
            SistemaIkor.Formularios.frmConfiguraBDs _FRMCONN = new frmConfiguraBDs();
            _FRMCONN.ShowDialog();

            //Cargar Info->>
            vCargarInformacion();

        }
        #region NAVEGACION
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                txtMasterPass.Visible = true;
            }
            else
            {
                label2.Visible = false;
                txtMasterPass.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label3.Visible = true;
                txtAdminPass.Visible = true;
                btnActualizarCuentaAdmin.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txtAdminPass.Visible = false;
                btnActualizarCuentaAdmin.Visible = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label5.Visible = true;
                txtProducPass.Visible = true;
                btnActualizarCuentaProduc.Visible = true;
            }
            else
            {
                label5.Visible = false;
                txtProducPass.Visible = false;
                btnActualizarCuentaProduc.Visible = false;
            }
        }
        #endregion NAVEGACION
        #endregion EVENTOS
        #region METODOS
        private void vCargarInformacion()
        {
            _dsLoad = new DataSet();

            //Cargar Info-->
            _dsLoad = _mSecurity.dsObtenerParametrosAPP();
            try
            {
                txtMasterUser.Text = _dsLoad.Tables[0].Rows[0][1].ToString().Trim();
                txtMasterPass.Text = _dsLoad.Tables[0].Rows[0][2].ToString().Trim();
                txtAdminUser.Text = _dsLoad.Tables[0].Rows[1][1].ToString().Trim();
                txtAdminPass.Text = _dsLoad.Tables[0].Rows[1][2].ToString().Trim();
                txtProducUser.Text = _dsLoad.Tables[0].Rows[2][1].ToString().Trim();
                txtProducPass.Text = _dsLoad.Tables[0].Rows[2][2].ToString().Trim();

                //BDS->>
                uctrlTablaConFiltroBDs.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                uctrlTablaConFiltroBDs.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                uctrlTablaConFiltroBDs.DataSource = _dsLoad.Tables[1].Copy();

                #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                this.uctrlTablaConFiltroBDs.gridDatos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
                this.uctrlTablaConFiltroBDs.gridDatos.MultiSelect = true;

                #endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
                //Desactivar el SortMode
                foreach (DataGridViewColumn columna in uctrlTablaConFiltroBDs.gridDatos.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                
            }
            catch (Exception EX)
            {
                MessageBox.Show("Connect BD Fail: \n - " + EX.Message, "Atención"
                                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion METODOS
    }
}
