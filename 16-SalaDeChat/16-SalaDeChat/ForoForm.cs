using _16_SalaDeChat.Vista;
using Mensajeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_SalaDeChat
{
    public partial class ForoForm : Form
    {
        private readonly Usuario usuario;        
        private Publicacion _Publicacion { get; init; }
        private event EventHandler<Comentario> NuevoMensajeEvent;
        public ForoForm(Usuario u)
        {
            InitializeComponent();
            #region Hardcodeamos la publicacion y el comentario para simplificar la demo
            _Publicacion = new("Como debbugear en C#");
            _Publicacion.Comentarios.Add(Publicacion.HardcodearComentario());
            RedManager.Publicaciones.Add(_Publicacion);
            #endregion

            _Publicacion.NuevoMensajeEvent += AgregarComentario;
            usuario = u;
        }
        private void ForoForm_Load(object sender, EventArgs e)
        {
            RefrescarPublicacion();
        }

        private void AgregarComentario(object sender,Comentario comentario)
        {
            if (_Publicacion.Comentarios.Add(comentario))
            {
                RefrescarPublicacion();
            }
        }
        /// <summary>
        /// Refresca el listbox de la publicacion
        /// </summary>
        private void RefrescarPublicacion()
        {
            //Mapeamos un Comentario a ComentarioVista para mostrar solo los valores que nos interesa mostrar y no todo
            List<ComentarioVista> comentarioVistas = _Publicacion.Comentarios.Select(
                c => new ComentarioVista(
                    c.Tiempo,
                    c.Contenido,
                    RedManager.ObtenerNickName_PorId(c.IdUsuario)))
                .ToList();
            lstPublicacion.DataSource = null;
            lstPublicacion.DataSource = comentarioVistas;
            lstPublicacion.DisplayMember = "DataFormateada";
        }

        private void lstPublicacion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new ChatForm(usuario, _Publicacion).Show();
        }

        private void btnSimularInteracion_Click(object sender, EventArgs e)
        {
            Guid IdusuarioCreadorDelPost = _Publicacion.Comentarios.FirstOrDefault().IdUsuario;
            Usuario usuarioCreadorDelPost = RedManager.Usuarios.FirstOrDefault(u => u.Id == IdusuarioCreadorDelPost);
            new ChatForm(usuarioCreadorDelPost, _Publicacion).Show();
        }
    }
}
