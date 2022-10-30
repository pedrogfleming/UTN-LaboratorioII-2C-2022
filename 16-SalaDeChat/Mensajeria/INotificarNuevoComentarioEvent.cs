using System;

namespace Mensajeria
{
    public interface INotificarNuevoComentarioEvent
    {
        bool AgregarComentario(Comentario c);
    }
}
