using EntidadesTienda;
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
    public partial class DetalleProductoForm : Form
    {
        private Producto Producto { get; set; }
        public DetalleProductoForm(Producto p) 
        {
            InitializeComponent();
            Producto = p;
            txtDescripcion.Text = Producto.Descripcion;
            txtNombre.Text = Producto.Nombre;
            numUpDownPrecio.Value = Producto.Precio;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>()
            {
                txtDescripcion.Text,
                txtNombre.Text,
                numUpDownPrecio.Value.ToString(),
            };

            if (ValidarInputs(strings))
            {
                Producto.Nombre = txtNombre.Text;
                Producto.Descripcion = txtDescripcion.Text;
                Producto.Precio = numUpDownPrecio.Value;
                VistaManager.RefrescarDGV.Invoke();
                Close();
            }
        }
        /// <summary>
        /// Chequea que ninguno de los elementos sea nullo o vacio
        /// </summary>
        /// <param name="inputs">Listado de stringsa validar</param>
        /// <returns>False si alguno es vacio "" o nullo, true en caso de que sean validos</returns>
        private bool ValidarInputs(List<string> inputs)
        {
            return inputs.Any(i => !string.IsNullOrWhiteSpace(i));
        }
    }
}
