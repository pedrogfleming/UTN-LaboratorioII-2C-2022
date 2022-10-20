using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace VistaFormulario
{
    public partial class formPrincipal : Form
    {
        /// <summary>
        /// En este atributo vamos a guardar la dependencia a utilizar
        /// </summary>
        private readonly IMostrarMensaje _mostrarMensaje;
        /// <summary>
        /// Recibe una instancia de una clase que implemente IMostrarMensaje
        /// </summary>
        /// <param name="mostrarMensaje"></param>
        public formPrincipal(IMostrarMensaje mostrarMensaje)
        {
            //Guardamos la dependencia en el atributo del form
            _mostrarMensaje = mostrarMensaje;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMensaje.Text))
            {
                _mostrarMensaje.Mostrar(txtMensaje.Text);
            }
        }
    }
}
