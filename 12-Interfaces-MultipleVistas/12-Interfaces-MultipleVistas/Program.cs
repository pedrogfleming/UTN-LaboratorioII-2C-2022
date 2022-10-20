using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notificaciones;
using Vista;

namespace VistaFormulario
{
    internal static class Program
    {
        //Declaramos una variable donde vamos a guardar la dependencia
        private static IMostrarMensaje _mostrarMensaje;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Guardamos en la interfaz la instancia de la dependencia
            #region Usando la consola
            _mostrarMensaje = new MostrarConsola();
            #endregion
            #region Usando un PopUp
            //_mostrarMensaje = new PopUpForm();
            #endregion
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //La injeccion la hacemos por constructor
            Application.Run(new formPrincipal(_mostrarMensaje));
        }
    }
}
