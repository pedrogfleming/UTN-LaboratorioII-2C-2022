using System;

namespace Mensajeria
{
    public interface INotificarNuevoComentarioEvent
    {
        bool AgregarComentario(object formSender,Comentario c);
    }
}
