using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    /// <summary>
    /// La clase que recibe el delegado y lo invoca
    /// </summary>
    public partial class Form2 : Form
    {
        private Action<string> _notificar;
        public Form2(Action<string> notificar)
        {
            InitializeComponent();
            _notificar = notificar;
        }

        private void btnEnviarNotificacion_Click(object sender, EventArgs e)
        {            
            if (_notificar != null)
            {
                if (!string.IsNullOrEmpty(rtxNotificacion.Text))
                {
                    _notificar.Invoke(rtxNotificacion.Text);
                }
            }
        }
    }
}
