using System.Windows.Forms;
using Vista;

namespace VistaFormulario
{
    public class PopUpForm : IMostrarMensaje
    {
        public void Mostrar(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
