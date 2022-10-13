using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Vista;

namespace VistaFormulario
{
    internal static class Program
    {
        private static IMostrarMensaje _mostrarMensaje;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Usando la consola
            _mostrarMensaje = new MostrarConsola();
            #endregion
            #region Usando un PopUp
            //_mostrarMensaje = new PopUpForm();
            #endregion
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formPrincipal(_mostrarMensaje));
        }
    }
}
