using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SistemaIkor
{
    /// <summary>
    /// Autor: 
    ///     Miguel Gutierrez Arroyo
    /// Fecha: 
    ///     2014/05/06
    /// 
    /// Descripcion: 
    ///     Clase para el modelo de metodos de Seguridad de la Aplicacion.    
    /// 
    /// </summary> 
    public class clSeguridad
    {
        #region PROPIEDADES PRIVADAS
        #endregion PROPIEDADES PRIVADAS
        #region PROPIEDADES PUBLICAS
        #endregion PROPIEDADES PUBLICAS
        #region METODOS PÚBLICOS
        public static void vCargaForma(Form Formulario, Form FormularioPadre, string strText)
        {

            Formulario.Text = strText;

            foreach (Form ctr in FormularioPadre.MdiChildren)
            {
                if (ctr.Text == Formulario.Text)
                {
                    ctr.Focus();
                    Formulario.Dispose();
                    return;
                }

            }            

            Formulario.WindowState = FormWindowState.Maximized;
            Formulario.MdiParent = FormularioPadre;
            Formulario.ControlBox = false;

            Formulario.BackgroundImage = SistemaIkor.Properties.Resources.fondo;
            Formulario.Icon = SistemaIkor.Properties.Resources.ToolboxWindow;
            Formulario.BackgroundImageLayout = ImageLayout.Stretch;
            Formulario.Show();
            Formulario.WindowState = FormWindowState.Maximized;
            
        }
        public static string strLeerRegistro(string Nombre)
        {

            RegistryKey myKey = getLlaveRegistro();
            if (myKey != null)
            {
                try
                {
                    return myKey.GetValue(Nombre).ToString();
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
                return System.Configuration.ConfigurationSettings.AppSettings.Get(Nombre);
        }
        private static RegistryKey getLlaveRegistro()
        {
            RegistryKey ret;
            try
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\SistemaIkor");
                ret = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SistemaIkor", true);

            }
            catch
            {
                ret = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SistemaIkor", true);
            }
            return ret;
        }
        private static RegistryKey getLlaveRegistroServer()
        {
            RegistryKey ret;
            try
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\SistemaIkor\Server");
                ret = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SistemaIko\Serverr", true);

            }
            catch
            {
                ret = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SistemaIkor\Server", true);
            }
            return ret;
        }
        public static void vEscribirRegistro(string Nombre, string Valor)
        {

            try
            {
                RegistryKey myKey = getLlaveRegistro();
                if (myKey != null)
                    myKey.SetValue(Nombre, Valor);
            }
            catch
            {
                try
                {
                    System.Configuration.ConfigurationSettings.AppSettings.Set(Nombre, Valor);
                }
                catch
                {
                }
            }
        }
        #endregion METODOS PÚBLICOS
    }
}
