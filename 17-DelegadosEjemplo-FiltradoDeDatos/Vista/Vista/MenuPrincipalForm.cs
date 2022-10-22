using EntidadesTienda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuPrincipalForm : Form
    {

        public MenuPrincipalForm()
        {
            InitializeComponent();
            dgvProductos.DataSource = TiendaManager.Productos;
            VistaManager.RefrescarDGV = RefrescarDGV;
        }
        
        private void RefrescarDGV()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = TiendaManager.Productos;
        }

        private void btnMostrarDetalleProducto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvProductos.SelectedRows)
            {
                // Con el ? le indico que puede llegar a ser un valor null
                Producto? p = item.DataBoundItem as Producto;
                if(p is not null)
                {
                    TiendaManager.MostrarDetalle(p);
                }
            }
        }
    }
}
