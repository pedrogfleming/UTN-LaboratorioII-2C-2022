using System;
using System.Diagnostics;
using Vista;

namespace Notificaciones
{
    /// <summary>
    /// Muestra por consola un mensaje al usuario
    /// </summary>
    public class MostrarConsola : IMostrarMensaje
    {

        /// <summary>
        /// Muestre un mensaje por la consola del IDE
        /// </summary>
        /// <param name="mensaje"></param>
        public void Mostrar(string mensaje)
        {
            Debug.WriteLine(mensaje);
        }
    }
}
