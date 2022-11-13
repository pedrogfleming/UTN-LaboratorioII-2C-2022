using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    /// <summary>
    /// La clase suscriptora al evento
    /// </summary>
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
        /// Metodo que se ejecuta cuando se invoque el delegado
        /// </summary>
        /// <param name="notificacion"></param>
        private void AgregarNotificacion(string notificacion)
        {
            totalNotificacionesSinLeer++;
            lbNotificaciones.Text = $"Notificaciones({totalNotificacionesSinLeer})";
            historialNotificaciones.Add(notificacion);
        }

        /// <summary>
        /// Metodo que se ejecuta cuando se invoque el delegado
        /// </summary>
        /// <param name="notificacion"></param>
        private void GuardarNuevaNotificacionEnTxt(string notificacion) 
        {
            try
            {
                string rutaDirectorio = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(rutaDirectorio, "historialNotificaciones.txt");
                using (StreamWriter streamWriter = new StreamWriter(rutaArchivo, true))
                {
                    streamWriter.WriteLine(notificacion);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnAbrirForm_Click(object sender, EventArgs e)
        {
           Action<string> ac1 = AgregarNotificacion;
           Action<string> ac2 = GuardarNuevaNotificacionEnTxt;
           ac1 += ac2;
           Form2 f2 = new Form2(ac1);
           f2.Show();
        }
    }
}
