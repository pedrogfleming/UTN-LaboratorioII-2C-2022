using System;

namespace Mensajeria
{
    public interface IPublicacion
    {
        bool AgregarComentario(object formSender,Comentario c);
    }
}
