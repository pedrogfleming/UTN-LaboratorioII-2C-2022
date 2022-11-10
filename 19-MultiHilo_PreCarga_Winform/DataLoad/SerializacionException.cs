using System;

namespace DataLoad
{
    public class SerializacionException : Exception
    {
        private static string mensajeError;

        static SerializacionException()
        {
            mensajeError = "Error en la serializacion";
        }

        public SerializacionException() : this(SerializacionException.mensajeError)
        {
        }
        public SerializacionException(string mensaje) : base(mensaje)
        {
        }

        public SerializacionException(Exception innerException) : base(SerializacionException.mensajeError, innerException)
        {
        }
    }
}
