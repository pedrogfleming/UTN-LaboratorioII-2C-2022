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
    /// La clase publicadora del evento
    /// </summary>
    public partial class Form2 : Form
    {
        public event Action<string> notificacionEntrante;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviarNotificacion_Click(object sender, EventArgs e)
        {
            //Chequeamos que haya suscriptores a este evento
            if (notificacionEntrante != null)
            {
                if (!string.IsNullOrEmpty(rtxNotificacion.Text))
                {
                    //Publicamos el mensaje para que aquellos que lo esten escuchando,
                    //Actuen en consecuencia
                    notificacionEntrante.Invoke(rtxNotificacion.Text);
                }
            }
        }
    }
}
