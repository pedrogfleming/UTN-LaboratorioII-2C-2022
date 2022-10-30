using System;
using System.Collections.Generic;
using System.Linq;

namespace Mensajeria
{
    public class Publicacion : INotificarNuevoComentarioEvent
    {
        public event Refrescar NuevoMensajeEvent;
        public Guid Id { get; set; }
        /// <summary>
        /// Declaro como HashSet los comentarios para que sean unicos
        /// </summary>
        public HashSet<Comentario> Comentarios { get; init; }
        public string Titulo { get; set; }

        public Publicacion(string titulo)
        {
            Id = Guid.NewGuid();
            Comentarios = new();
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
                Comentarios.Add(c);
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
