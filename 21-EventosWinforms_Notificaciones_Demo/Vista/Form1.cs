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
        private int totalNotificacionesSinLeer;
        private List<string> historialNotificaciones;
        public Form1()
        {
            totalNotificacionesSinLeer = 0;
            historialNotificaciones = new List<string>();
            InitializeComponent();
        }

        private void lbNotificaciones_Click(object sender, EventArgs e)
        {
            if(totalNotificacionesSinLeer > 0)
            {
                StringBuilder sb = new();
                historialNotificaciones.ForEach(n => sb.AppendLine(n));
                MessageBox.Show(sb.ToString());
                totalNotificacionesSinLeer = 0;
            }
        }
        /// <summary>
        /// Event handler,
        /// El metodo que se ejecuta cuando se invoca el evento
        /// </summary>
        /// <param name="notificacion"></param>
        private void AgregarNotificacion(string notificacion)
        {
            totalNotificacionesSinLeer++;
            lbNotificaciones.Text = $"Notificaciones({totalNotificacionesSinLeer})";
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
