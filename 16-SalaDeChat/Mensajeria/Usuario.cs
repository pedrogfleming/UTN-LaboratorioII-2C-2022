using System;
using System.Collections.Generic;

namespace Mensajeria
{
    public class Usuario
    {
        public Usuario(string nickName, string email)
        {
            this.nickName = nickName;
            this.email = email;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string nickName { get; set; }
        public string email { get; set; }
        public EnviarMensaje Enviar { get; set; }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.Id == u2.Id || u1.email == u2.email || u1.nickName == u2.nickName;
        }
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }
    }
}
