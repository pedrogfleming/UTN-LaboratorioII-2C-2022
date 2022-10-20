using System.Windows.Forms;
using Vista;

namespace VistaFormulario
{
    /// <summary>
    /// Muestra un popup con el mensaje al usuario
    /// </summary>
    public class PopUpForm : IMostrarMensaje
    {
        int contador = 0;
        public void Mostrar(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        public void contarMensajes(int entero)
        {
            contador += entero;
        }
    }
}
