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
    public partial class Form1 : Form
    {        
        private int totalNotificaciones;
        private List<string> historialNotificaciones;
        public Form1()
        {
            totalNotificaciones = 0;
            historialNotificaciones = new List<string>();
            InitializeComponent();
        }

        private void lbNotificaciones_Click(object sender, EventArgs e)
        {
            if(totalNotificaciones > 0)
            {
                StringBuilder sb = new();
                historialNotificaciones.ForEach(n => sb.AppendLine(n));
                MessageBox.Show(sb.ToString());
            }
        }
        /// <summary>
        /// Event handler,
        /// El metodo que se ejecuta cuando se invoca el evento
        /// </summary>
        /// <param name="notificacion"></param>
        private void AgregarNotificacion(string notificacion)
        {
            totalNotificaciones++;
            lbNotificaciones.Text = $"Notificaciones({totalNotificaciones})";
            historialNotificaciones.Add(notificacion);
        }

        private void btnAbrirForm_Click(object sender, EventArgs e)
        {
           Form2 f2 = new Form2();
           f2.notificacionEntrante += AgregarNotificacion;
           f2.Show();
        }
    }
}
