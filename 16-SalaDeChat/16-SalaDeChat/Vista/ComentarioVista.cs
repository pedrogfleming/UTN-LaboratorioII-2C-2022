using Mensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SalaDeChat.Vista
{
    /// <summary>
    /// Cree esta clase para mostrar mas facil los datos en el listbox
    /// </summary>
    public class ComentarioVista
    {
        public DateTime Tiempo { get; set; }
        public string Contenido { get; set; }
        public string UsuarioNickName { get; set; }

        public string DataFormateada { get; set; }

        public ComentarioVista(DateTime tiempo,string contenido, string nickName)
        {
            Tiempo = tiempo;
            Contenido = contenido;
            UsuarioNickName = nickName;
        }
        public override string ToString()
        {
            DataFormateada = $"{Tiempo.ToShortTimeString()} - {UsuarioNickName} : {Contenido}";
            return DataFormateada;
        }
    }
}
