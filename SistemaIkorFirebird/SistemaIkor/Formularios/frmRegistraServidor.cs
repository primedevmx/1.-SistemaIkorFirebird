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
    public partial class frmRegistraServidor : Form
    {
        #region CONSTRUCTORES
        public frmRegistraServidor()
        {
            InitializeComponent();
            this.vCargarDatos();           
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strKey = "";

            try
            {
                //Escribir->>
                Properties.Settings.Default.InstanciaServer = txtCC.Text.Trim();
                Properties.Settings.Default.Save();

                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServer;
                if (strKey != "Database=localhost:C:\\SistemaIkor\\DBSECURITYIKOR.GDB;User_Name=sysdba;Password=masterkey")
                {
                    this.vCargarDatos();           

                    MessageBox.Show("Se ha registrado correctamente la [Instancia del Servidor]. \n \n - Puede usted continuar. ", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);                    
                }
            }
            catch { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null,null);
            }
        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            frmTestConection FRMM = new frmTestConection(this.txtCC.Text.Trim(), "[SECURITY BD]");
            FRMM.ShowDialog();
        }
        private void txtUserBD_TextChanged(object sender, EventArgs e)
        {
            txtCC.Text = strArmaCCSS();
        }
        private void frmRegistraServidor_Load(object sender, EventArgs e)
        {

        }
        #endregion EVENTOS     
        #region METODOS
        private string strArmaCCSS()
        {
            
            //Database= localhost : C:\\SistemaIkor\\DBSECURITYIKOR.GDB;
            //User_Name= sysdba; Password=masterkey

            string strRet = "";

            strRet = "Database=" + txtIP.Text.Trim() + ":" + txtRuta.Text.Trim()  + "\\" + txtNombreBD.Text.Trim() + ";" +
                     "User_Name=" + txtUserBD.Text.Trim() + ";" +
                     "Password=" + txtPasswodBD.Text.Trim() ;

            return strRet;
        }
        private void vCargarDatos()
        {
            string strKey = "";

            try
            {
                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServer;
                if (strKey != "")
                {
                    txtCC.Text = strKey;
                    string[] strArrK = strKey.Split(';');
                    
                    //Usuario->>
                    txtUserBD.Text = strArrK[1].Substring(10);
                    txtPasswodBD.Text = strArrK[2].Substring(9);
                    
                    //IP->>
                    string[] strArrK2 = strArrK[0].Split(':');
                    txtIP.Text = strArrK2[0].Substring(9);

                    string strTemp = strArrK2[1] + ":" +strArrK2[2];
                    
                    //Ruta-BD->>
                    string[] strArrK3 = strTemp.Split('\\');
                    int intCount = strArrK3.Length;
                    string strRoute = "";
                    for (int i = 0; i < intCount - 1; i++ )
                    {
                        if (strArrK3[i] != "")
                        {
                            strRoute += strArrK3[i] + "\\";
                        }
                        strRoute = strRoute.Substring(0, strRoute.Length - 2);
                    }

                    txtRuta.Text += strRoute;
                    txtNombreBD.Text = strArrK3[intCount];
                }
                else
                {
                    txtCC.Text = "";
                }
            }
            catch { }        
        }
        #endregion METODOS        
    }
}
