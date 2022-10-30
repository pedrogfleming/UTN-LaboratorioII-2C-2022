using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria
{
    public static class RedManager
    {
        public static List<Usuario> Usuarios{ get; set; }
        public static List<Publicacion> Publicaciones { get; set; }

        static RedManager()
        {
            Usuarios = new()
            {
                new Usuario("mateobik", "mtnbik@storesup.fun"),
                new Usuario("godjar","godjar@honghukangho.com"),
                new Usuario("edarmon","edarmon@gotcertify.com"),
                new Usuario("thomas82","thomas82@affogatgaroth.com")
                
            };
            Publicaciones = new();
        }
        /// <summary>
        /// Buscar el nickname segun el id del usuario pasado por parametro
        /// </summary>
        /// <param name="idUsuario">Id del usuario que buscamos obtener su nickname</param>
        /// <returns>El nickname del id usuario solicitado, si no null</returns>
        public static string ObtenerNickName_PorId(Guid idUsuario)
        {
            return Usuarios.FirstOrDefault(u => u.Id == idUsuario)?.nickName;
        }
    }
}
