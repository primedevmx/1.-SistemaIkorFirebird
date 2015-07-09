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


namespace SistemaIkor.Clases
{
    public class mSeguridad
    {
        #region PROPIEDADES PRIVADAS
        //String-->
        private string _strUsuarioSistema = "";
        private string _strConnFB = "";

        //Bool-->
        private bool _bUsuarioAdmin = false;
        private bool _bUsuarioProduc = false;
        #endregion PROPIEDADES PRIVADAS
        #region PROPIEDADES PUBLICAS
        //String-->
        public string strUsuarioSistema
        {
            get
            {
                return this._strUsuarioSistema;
            }
            set
            {
                this._strUsuarioSistema = value;
            }
        }
        public string strConnFB
        {
            get
            {
                return this._strConnFB = Properties.Settings.Default.InstanciaServer;
            }
            set
            {
                this._strConnFB = value;
            }
        }
       
        //Bool-->
        public bool bUsuarioAdmin
        {
            get
            {
                return this._bUsuarioAdmin;
            }
            set
            {
                this._bUsuarioAdmin = value;
            }
        }
        public bool bUsuarioProduc
        {
            get
            {
                return this._bUsuarioProduc;
            }
            set
            {
                this._bUsuarioProduc = value;
            }
        }
        #endregion PROPIEDADES PUBLICAS
        #region METODOS PUBLICOS
        #region LOGIN
        public DataSet dsValidaAutenticacion(string vchCuenta, string vchPassword)
        {
            DataSet dsReturn = new DataSet("AutenticacionUsuario");
            string strCommand =
                "SELECT * FROM TBLUSUARIOS WHERE VCHCUENTA = '" + vchCuenta+"' AND " +
                "VCHPASSWORD = '"+vchPassword+"'";

            try
            {
                dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);
            }
            catch {
                dsReturn = null;
            }


            return dsReturn;
        
        }
        #endregion LOGIN
        #region USUARIOS
        public DataSet dsObtenerParametrosAPP()
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";

            strCommand = "SELECT  idusuario as \"Usuario ID\", vchcuenta as \"Cuenta\", vchpassword as \"Contraseña\", vchnombre as \"Descripcion de la Cuenta\", badmin as \"Administrador?\" FROM TBLUSUARIOS";

           
                //USRS->>
                DataTable dtR1 =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand).Tables[0];
                dtR1.TableName = "Usuarios";
                dsReturn.Tables.Add(dtR1.Copy());

                //TB_BDS->>
                strCommand = " SELECT  idbd as \"BD ->> ID\", vchid as \"ID\", vchpassword as \"Password\", vchip as \"IP\", vchruta as \"RUTA\", vchnombre as \"Nombre de la BD\", vchdescripcion as \"Descripcion de la BD\" " +
                              " FROM TBLBDS  WHERE bactivo = 1 ORDER BY idbd DESC ";

                DataTable dtR2 =
                   FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand).Tables[0];
                dtR2.TableName = "BasesdeDatos";

                dsReturn.Tables.Add(dtR2.Copy());
           


            return dsReturn;

        }
        public DataSet dsActualizarUsuario(string strCuenta, string strPassword)
        {
            DataSet dsReturn = new DataSet("ActualizacionUsuario");

            string strCommand = "";

            strCommand = "UPDATE TBLUSUARIOS SET VCHPASSWORD = '" + strPassword
               + "' WHERE VCHCUENTA = '" + strCuenta + "' ";

            try
            {
                dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand);

                strCommand = " SELECT * FROM TBLUSUARIOS WHERE VCHCUENTA = '" + strCuenta + "' ";

                dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);
            }
            catch
            {
                dsReturn = null;
            }


            return dsReturn;

        }
        #endregion USUARIOS
        #region BDS
        public DataSet dsObtenerConfiguraBDs()
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";

            try
            {
                //TB_BDS->>
                strCommand = " SELECT  idbd as \"BD ->> ID\", vchid as \"ID\", vchpassword as \"Password\", vchip as \"IP\", vchruta as \"RUTA\", vchnombre as \"Nombre de la BD\", vchdescripcion as \"Descripcion de la BD\", VCHCCSS as \"CCSS\" " +
                              " FROM TBLBDS WHERE bactivo = 1 ORDER BY idbd DESC";

                DataTable dtR2 =
                   FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand).Tables[0];
                dtR2.TableName = "BasesdeDatos";

                dsReturn.Tables.Add(dtR2.Copy());
            }
            catch
            {
                dsReturn = null;
            }


            return dsReturn;

        }
        public DataSet dsAgregaBD(string strVCHID, string strVCHPASSWORD, string strVCHIP, string strVCHRUTA,
            string strVCHNOMBRE, string strVCHDESCRIPCION,string strVCHCCSS)
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strID = "";

            //IDBD->>
            strCommand = "SELECT MAX(idbd)+1 from tblbds";

            try
            {
                dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);
                //Ajuste->>
                if(dsReturn.Tables[0].Rows[0][0].ToString().Trim() == "")
                {
                    dsReturn.Tables[0].Rows[0][0] = "1";
                }

                //ID-OK->>
                if (dsReturn.Tables[0].Rows.Count > 0)
                {
                    strID = dsReturn.Tables[0].Rows[0][0].ToString();
                    strCommand = "insert into tblbds (idbd, vchid, vchpassword, vchip, vchruta, vchnombre, vchdescripcion, bactivo, vchCCSS) values ("
                               + "'" + strID + "'," 
                               +"'"+ strVCHID + "'," 
                               +"'"+ strVCHPASSWORD + "'," 
                               +"'"+ strVCHIP + "'," 
                               +"'"+ strVCHRUTA + "'," 
                               +"'"+ strVCHNOMBRE + "'," 
                               +"'"+ strVCHDESCRIPCION + "'," 
                               +""+ "1" + "," 
                               +"'" + strVCHCCSS + "')";
                    //Insert-->
                    dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand);

                    //INSERT-OK->>
                    strCommand = "SELECT * FROM tblbds WHERE idbd= " + strID;

                    //Select-->
                    dsReturn =
                    FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand);
                    
                }
                else
                {
                    dsReturn = null;                
                }

            }
            catch
            {
                dsReturn = null;
            }


            return dsReturn;

        }
        public DataSet dsEliminaBD(string strIDbd)
        { 
            DataSet dsRet = new DataSet ();
            string strCommand = "";

            try
            {
                //UPDT-->
                strCommand = "UPDATE tblbds SET bactivo = 0 WHERE idbd = " + strIDbd;

                dsRet =
                   FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand);

                
                //SELECT->>
                strCommand = "SELECT * FROM tblbds WHERE bactivo = 0 AND idbd = " + strIDbd;

                dsRet =
                   FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);

            }
            catch {
                dsRet = null;
            }

            return dsRet;        
        }
        #endregion BDS
        #region ADMINISTRADOR-DE-REPORTES
        public DataSet dsObtieneTablasBD(string strCONN_STR)
        {
            DataSet dsRet = new DataSet();
            string strCommand = " SELECT RDB$RELATION_NAME" +
                                " FROM RDB$RELATIONS" +
                                " WHERE RDB$SYSTEM_FLAG = 0 AND" +
                                " RDB$RELATION_NAME NOT IN (SELECT RDB$VIEW_NAME"+
                                " FROM RDB$VIEW_RELATIONS); ";

            try
            {
                dsRet =
                   FirebirdHelperADO.ExecuteDataset(strCONN_STR,  strCommand);

            }
            catch
            {
                dsRet = null;
            }

            return dsRet;
        }
        public DataTable dtObtieneConsultaTabla(string strCONN_STR, string strNAME_TBL)
        {
            DataTable dtRet = new DataTable();
            
            string strCommand = " SELECT * FROM " + strNAME_TBL;
                                

            try
            {
                dtRet =
                   FirebirdHelperADO.ExecuteDataset(strCONN_STR,  strCommand).Tables[0];

            }
            catch
            {
                dtRet = null;
            }

            return dtRet;
        }
        public DataSet dsGuardarReporte(string strCONN_STR, string str_IDBD, string strNAME_SELECT, string str_NAMEREP)
        {
            DataSet dsRet = new DataSet();
            string str_IDREP = "";
            string strCommand = "";

            //SELECT ID->>
            strCommand = "SELECT MAX(idrep)+1 FROM TBLREPORTES;";

            try
            {

                dsRet =
                   FirebirdHelperADO.ExecuteDataset(strCONN_STR, strCommand);

                if (dsRet != null && dsRet.Tables[0].Rows.Count > 0)
                {
                    str_IDREP = dsRet.Tables[0].Rows[0][0].ToString().Trim();
                    
                    //REG INICIAL->>
                    if (str_IDREP == "")
                    {
                        str_IDREP = "1";
                    }

                    //=>>
                    strCommand = "INSERT INTO TBLREPORTES (idrep, idbd, vchconsulta, vchnombre) VALUES ( " + str_IDREP +
                                                            ", " + str_IDBD +
                                                            ", '" + strNAME_SELECT +
                                                            "', '" + str_NAMEREP + " ');";


                    //INSERT->>                    
                    dsRet =
                       FirebirdHelperADO.ExecuteDataset(strCONN_STR,  strCommand);

                    //=>>
                    strCommand = "SELECT * FROM TBLREPORTES WHERE idrep = " + str_IDREP;

                    //SALIDA->>                     
                    dsRet =
                       FirebirdHelperADO.ExecuteDataset(strCONN_STR,  strCommand);

                }

            }
            catch
            {
                dsRet = null;
            }

            return dsRet;
        }
        public DataTable dtObtieneConsultaReportes(string strCONN_STR, string strID)
        {
            DataTable dtRet = new DataTable();

            string strCommand = "SELECT TB1.idrep, TB1.vchnombre ,TB1.vchconsulta, TB2.idbd, TB2.vchdescripcion  FROM tblreportes TB1 INNER JOIN  tblbds TB2 ON TB1.idbd = TB2.idbd" +
                                 " WHERE TB1.idbd = " + strID;
            try
            {
                dtRet =
                   FirebirdHelperADO.ExecuteDataset(strCONN_STR,  strCommand).Tables[0];

            }
            catch
            {
                dtRet = null;
            }

            return dtRet;
        }
        public DataSet dsEliminaRep(string strID_REP)
        {
            DataSet dsRet = new DataSet();
            string strCommand = null;

            //->>
            strCommand =
            " delete from tblreportes  where idrep = " + strID_REP;

            try
            {
                //Delete->>
                dsRet =
                   FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);                 
                if (dsRet == null)
                {
                    //->>
                    strCommand =
                        "select * from tblreportes where idrep = " + strID_REP;

                    //Select->>
                    dsRet =
                       FirebirdHelperADO.ExecuteDataset(this.strConnFB, strCommand);
                    if (dsRet.Tables[0].Rows.Count == 0)
                    {
                        //->>
                        strCommand =
                            "select distinct 'OK' from tblreportes";

                        //Salida->>
                        dsRet =
                           FirebirdHelperADO.ExecuteDataset(this.strConnFB,  strCommand);
                    }
                
                }
            }
            catch {
                dsRet = null;            
            }


            return dsRet;
        }

        #endregion ADMINISTRADOR-DE-REPORTES
        #region VISTA-REPORTES
        public DataTable dtConsultaReportes(string strCONN_STR, string strSELECT)
        {
            DataTable dtRet = new DataTable();

            //Ajuste->>
            string strCommand = strSELECT.Replace("\"","%'");
            strCommand = strCommand.Replace(" %'", " '");            

            try
            {
                dtRet =
                   FirebirdHelperADO.ExecuteDataset(strCONN_STR, strCommand).Tables[0];

            }
            catch
            {
                dtRet = null;
            }

            return dtRet;
        }
        #endregion VISTA-REPORTES
        #endregion METODOS PUBLICOS
    }
}
