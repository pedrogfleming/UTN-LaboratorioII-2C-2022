﻿using Mensajeria;
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
    public partial class ChatForm : Form
    {
        private Usuario Usuario { get; init; }
        private readonly IPublicacion _publicacion;
        public ChatForm(Usuario u1, IPublicacion publicacion)
        {            
            Usuario = u1;            
            _publicacion = publicacion;
            InitializeComponent();
            this.Text = Usuario.nickName;
        }
        /// <summary>
        /// Sender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxMensajeAEnviar.Text))
            {
                var comentario =new Comentario(DateTime.Now, rtxMensajeAEnviar.Text, Usuario.Id);
                if (_publicacion.AgregarComentario(this,comentario))
                {
                    MessageBox.Show("Enviado");
                }
                else
                {
                    MessageBox.Show("No se pudo mandar el comentario");
                }
            }
        }
    }
}