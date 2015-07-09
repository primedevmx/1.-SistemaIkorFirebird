using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaIkor
{
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
    public partial class frmLogin : Form
    {
        #region CONSTRUCTORES
        public frmLogin()
        {
            InitializeComponent();
            lblDatex.Text = "<<"+DateTime.Now.ToString()+">>";
        }
        #endregion CONSTRUCTORES
        #region PROPIEDADES
        bool _bAutentica = false;
        Clases.mSeguridad _mSecurity;
        string _strConnFirebid = "";
        DataSet _dsAutenticacion;
        #endregion PROPIEDADES
        #region EVENTOS
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _bAutentica = false;
            _mSecurity = new Clases.mSeguridad();
            _mSecurity.bUsuarioAdmin = false;
            _mSecurity.bUsuarioProduc = false;
            _dsAutenticacion = new DataSet();

            //Previa Verificacion->>
            string strKey = "";

            try
            {
                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServer;
                if (strKey == "User=SYSDBA;Password=masterkey;Database=C:\\SistemaIkor/dbSecurityIkor.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;")
                {
                    MessageBox.Show("[NO] se ha registrado correctamente la [Instancia del Servidor].  \n- Favor de configurar los parametros del servidor, no olvide registrar la [IP] del [Servidor].  \n \n - Por favor verifique. ", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
            }
            catch { }

            //Previa Validacion-->
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = string.Empty;
                txtUsuario.Focus();
                txtUsuario.SelectAll();
                MessageBox.Show("Favor de verificar su [Cuenta de Usuario] y [Contraseña].","Atención"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }

            //Versión Desarrollo-->
            if (txtPassword.Text == System.Configuration.ConfigurationSettings.AppSettings["DevPassKey"])
            {
                _bAutentica = true;
                _mSecurity.bUsuarioAdmin = true;
            }

            //Autenticacion->>
            if (!_bAutentica)
            {
                _dsAutenticacion =
                    _mSecurity.dsValidaAutenticacion(txtUsuario.Text.Trim(), txtPassword.Text.Trim());

                try
                {

                    if (_dsAutenticacion.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Favor de verificar su [Cuenta de Usuario] y [Contraseña].", "Atención"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //Admin->>
                        if (Convert.ToBoolean(_dsAutenticacion.Tables[0].Rows[0]["BADMIN"]))
                        {
                            _bAutentica = true;
                            _mSecurity.bUsuarioAdmin = true;
                        }
                        else
                        {
                            //Product-->
                            _bAutentica = true;
                            _mSecurity.bUsuarioProduc = true;
                        }

                    }              
                    
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Connect BD Fail: \n - " + EX.Message, "Atención"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //Show-->
            if (_bAutentica)
            {
                //LastUser->
                _mSecurity.strUsuarioSistema = txtUsuario.Text.Trim();
                try { clSeguridad.vEscribirRegistro("LastUser", _mSecurity.strUsuarioSistema); }
                catch { }

                frmPrincipal frmPpal = new frmPrincipal(_mSecurity);
                frmPpal.Show();
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
            else
            {
                MessageBox.Show("Favor de verificar su [Cuenta de Usuario] y [Contraseña].", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

        }    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {            
            try
            {
                txtUsuario.Text = clSeguridad.strLeerRegistro("LastUser");
            }
            catch { }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = Environment.UserName;
            }
            txtPassword.Focus();
            try
            {
                lblVersion.Text += " " + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                lblVersion.Text += " Desarrollo";
            }       

        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null,null);
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, null);

            }
        }  
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.M))
            {
                Formularios.frmRegistraServidor _FRM = new Formularios.frmRegistraServidor();
                _FRM.ShowDialog();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion EVENTOS
        #region METODOS
        #endregion METODOS        
    }
}