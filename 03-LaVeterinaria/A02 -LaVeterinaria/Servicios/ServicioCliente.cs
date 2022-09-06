using Domain;

namespace Veterinaria.Servicios
{
    /// <summary>
    /// El Servicio Cliente se encarga de realizar toda nuestra logica del CRUD
    /// </summary>
    public static class ServicioCliente
    {
        /// <summary>
        /// 
        /// </summary>
        private static List<Cliente> _clientes;


        static ServicioCliente()
        {
            _clientes = new();
        }

        /// <summary>
        /// Retorna todos los clientes
        /// </summary>
        public static List<Cliente> Clientes
        {
            get { return _clientes; }
        }
        #region Acciones de Escritura
        /// <summary>
        /// Da de alta un cliente
        /// </summary>
        /// <param name="c">El cliente a dar de alta</param>
        /// <returns>Retorna el cliente dado de alta</returns>
        public static bool Alta(Cliente c)
        {
            Cliente cliente = _clientes.Find(cliente => cliente == c);
            if (cliente is not null) { return false; }
            _clientes.Add(c);
            return true;
        }
        //2 - Baja cliente
        /// <summary>
        /// Se eliminara el/los cliente/s con el mismo Id o apellidio y nombre
        /// </summary>
        /// <param name="c">El cliente a eliminar</param>
        /// <returns>La cantidad de clientes eliminados</returns>
        public static int Eliminar(Cliente c)
        {
            Cliente cliente = _clientes.Find(cliente => cliente == c);
            if (cliente is null) { return 0; }
            return _clientes.RemoveAll(cliente => cliente == c);
        }
        /// <summary>
        /// Se modificara el cliente pasado por parametro
        /// </summary>
        /// <param name="c">El cliente a modificar con los nuevos valores</param>
        /// <returns>True si logro encontrar y modificar al cliente, false si no</returns>
        public static bool Modificar(Cliente c)
        {
            Cliente cliente = _clientes.Find(cliente => cliente == c);
            if (cliente is null) { return false; }
            cliente = c;
            return true;
        }
        #endregion
        #region Acciones de Lectura
        /// <summary>
        /// Obtiene un cliente en base a su id
        /// </summary>
        /// <param name="id">El id del cliente a buscar</param>
        /// <returns>Retorna el cliente si se encuentra,si no retorna null</returns>
        public static Cliente ObtenerPorId(Guid id)
        {
            return _clientes.FirstOrDefault(cliente => cliente.Id == id);
        }
        /// <summary>
        /// Obtiene un cliente por Apellido y nombre
        /// </summary>
        /// <param name="nombre"> nombre del cliente a buscar</param>
        /// <param name="apellido"> apellido del cliente a buscar</param>
        /// <returns>Retorna el cliente si se encuentra,si no retorna null</returns>
        public static Cliente ObtenerPorNombreCompleto(string nombre, string apellido)
        {
            return _clientes.FirstOrDefault(cliente =>
                cliente.Apellido == apellido &&
                cliente.Nombre == nombre);
        }
        #endregion
    }
}
