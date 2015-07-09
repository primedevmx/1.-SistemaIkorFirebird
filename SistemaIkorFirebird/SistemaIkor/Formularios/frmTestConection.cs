using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data.Common;
using FireBird.FirebirdHelper;
using System.Windows.Forms;

namespace SistemaIkor.Formularios
{
    public partial class frmTestConection : Form
    {
        Clases.mSeguridad _mSecurity = new Clases.mSeguridad();

        string _strConn = "";

        public frmTestConection()
        {
            InitializeComponent();
        }

        public frmTestConection(string strConn, string strName)
        {
            InitializeComponent();
            try
            {
                _strConn = strConn;
                string[] strArrK = _strConn.Split(';');
                //Servidor->>                     
                string [] strTemp = strArrK[0].Split('\\');
                //IP->>
                string[] strTemp2 = strTemp[0].Split(':');
                lblIP.Text = strTemp2[0].Substring(9);
                //Serever->>
                labelNombreServer.Text = strTemp[strTemp.Length - 1];
            }
            catch { }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = " SELECT RDB$RELATION_NAME" +
                                " FROM RDB$RELATIONS" +
                                " WHERE RDB$SYSTEM_FLAG = 0 AND" +
                                " RDB$RELATION_NAME NOT IN (SELECT RDB$VIEW_NAME" +
                                " FROM RDB$VIEW_RELATIONS); ";
                       
            
            Cursor.Current = Cursors.WaitCursor;

                try
                {
                    //Consulta->>
                    dsReturn =
                        FirebirdHelperADO.ExecuteDatasetTEST(_strConn,strCommand);
                    if (dsReturn.Tables[0].Rows.Count > 0)
                    {
                        txtSalida.Text = "Operacion realizada satisfactoriamente. - Se ha establecido correctamente la configuración de la [Base de Datos] del Servidor. \r\n \r\n -  Sistema IKOR.";
                        tslConn.Text = " - Conexión Exitosa - ";
                        tslConn.ForeColor = System.Drawing.Color.LightGreen;

                        Cursor.Current = Cursors.Arrow;

                    }

                }
                catch (Exception EX)
                {
                    dsReturn = null;
                    strSalida = EX.Message + " \r\n \r\n "
                        + " \r\n \r\n - Verifique la configuración de los parámetros del servidor.";
                    MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN-");
                    txtSalida.Text = strSalida;
                    tslConn.Text = " - Error en la conexión - ";
                    tslConn.ForeColor = System.Drawing.Color.Coral;
                }  
            
        }

    }
}
