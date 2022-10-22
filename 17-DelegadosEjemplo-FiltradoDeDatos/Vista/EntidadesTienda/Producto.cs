using System;

namespace EntidadesTienda
{
    public class Producto
    {
        public Producto(Guid id, string descripcion, string nombre, decimal precio)
        {
            Id = id;
            Descripcion = descripcion;
            Nombre = nombre;
            Precio = precio;
        }
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; } 
        public decimal Precio { get; set; }
    }
}
