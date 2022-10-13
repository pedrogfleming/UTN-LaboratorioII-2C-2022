using System;
using System.Diagnostics;
using Vista;

namespace View
{
    public class MostrarConsola : IMostrarMensaje
    {
        public void Mostrar(string mensaje)
        {
            Debug.WriteLine(mensaje);
        }
    }
}
