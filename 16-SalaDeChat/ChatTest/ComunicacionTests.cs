using Mensajeria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChatTest
{
    [TestClass]
    public class ComunicacionTests
    {
        private readonly Publicacion _publicacion;
        private List<Comentario> _comentarios;

        public ComunicacionTests()
        {
            _publicacion = new Publicacion("Restaurantes en Buenos aires");
            _publicacion.NuevoMensajeEvent += AgregarComentario;
        }
        /// <summary>
        /// Agrega un comentario a la publicacion enviado desde otro formulario
        /// </summary>
        /// <param name="sender">Data del formulario que envio el comentario</param>
        /// <param name="comentario"> El comentario a agregar a la publicacion</param>
        private void AgregarComentario(object sender, Comentario comentario)
        {
            _publicacion.Comentarios.Add(comentario);
        }
        [TestMethod]
        public void GenerarNuevoMensajeTestOk()
        {
            
        }
    }
}
