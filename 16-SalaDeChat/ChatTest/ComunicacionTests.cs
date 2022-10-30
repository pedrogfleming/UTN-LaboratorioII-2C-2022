using Mensajeria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatTest
{
    [TestClass]
    public class ComunicacionTests
    {
        private readonly Publicacion _publicacion;
        private List<Comentario> UltimosComentarios;

        public ComunicacionTests()
        {
            _publicacion = new Publicacion("Restaurantes en Buenos aires");
            _publicacion.NuevoMensajeEvent += () => UltimosComentarios = _publicacion.Comentarios.ToList();
        }

        [TestMethod]
        public void ActualizarListaAlAgregarMensaje()
        {
            Usuario u = new("raichu20", "raichu@gmail.com");
            Comentario c = new(DateTime.Now.AddDays(-100), "Hay uno muy bueno en avenida boedo", u.Id);
            _publicacion.AgregarComentario(c);
            Assert.IsTrue(UltimosComentarios.SequenceEqual(_publicacion.Comentarios));
        }
    }
}
