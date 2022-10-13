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
        private readonly IMostrarMensaje _mostrarMensaje;
        public formPrincipal(IMostrarMensaje mostrarMensaje)
        {
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
