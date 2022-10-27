using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
    public class Comentario
    {
        /// <summary>
        /// Id del comentario
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Fecha y hora en que se publico el comentario
        /// </summary>
        public DateTime Tiempo { get; set; }
        public string Contenido { get; set; }
        /// <summary>
        /// El id del usuario que publico el comentario
        /// </summary>
        public Guid IdUsuario { get; set; }

        public Comentario(DateTime tiempo,string contenido, Guid idUsuario)
        {
            Tiempo = tiempo;
            Contenido = contenido;
            IdUsuario = idUsuario;
            Id = Guid.NewGuid();
        }

        public static bool operator ==(Comentario c1,Comentario c2)
        {
            return c1.Id == c2.Id;
        }
        public static bool operator !=(Comentario c1, Comentario c2)
        {
            return !(c1 != c2);
        }
    }
}
