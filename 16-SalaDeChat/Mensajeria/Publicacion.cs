using System;
using System.Collections.Generic;
using System.Linq;

namespace Mensajeria
{
    public class Publicacion : INotificarNuevoComentarioEvent
    {
        public event Refrescar NuevoMensajeEvent;
        /// <summary>
        /// Declaro como HashSet los comentarios para que sean unicos
        /// </summary>
        private HashSet<Comentario> comentarios;
        public Guid Id { get; set; }
        /// <summary>
        /// Uso una IReadOnlyCollection porque de esa manera obligo a usar siempre el metodo AgregarComentario(c) 
        /// Cuando se quiere agregar un nuevo comentario a la coleccion.
        /// De esa manera, no se puede agregar o quitar elementos a la coleccion desde afuera de la clase
        /// Lo que asegura que siempre se invoque el evento Refrescar NuevoMensajeEvent al agregar
        /// </summary>
        public IReadOnlyCollection<Comentario> Comentarios { get { return comentarios; } } 
        public string Titulo { get; set; }

        public Publicacion(string titulo)
        {
            Id = Guid.NewGuid();
            comentarios = new();
            Titulo = titulo;
        }
        /// <summary>
        /// Agregar un comentario a la publicacion si no existe. 
        /// Se invoca adentro el evento de actualizar la vista de la publicacion
        /// </summary>
        /// <param name="formSender">Data del origen del evento, en este caso, el formulario origen</param>
        /// <param name="c"> El comentario a agregar</param>
        /// <returns></returns>
        public bool AgregarComentario(Comentario c)
        {
            //Siempre chequeamos que el evento no venga null
            if(NuevoMensajeEvent is not null)
            {
                comentarios.Add(c);
                NuevoMensajeEvent.Invoke();
                return true;
            }
            //Si el evento no tiene asociado ningun metodeo, no se agrega el comentario y se retorna false
            return false;
        }

        public static Comentario HardcodearComentario()
        {
            return new Comentario(
                DateTime.Now.AddDays(-2),
                "Hola, como debuggeo en C#", 
                RedManager.Usuarios.FirstOrDefault().Id);
        }
    }
}
