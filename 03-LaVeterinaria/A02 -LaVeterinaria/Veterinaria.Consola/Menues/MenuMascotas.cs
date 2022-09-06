using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Consola.Menues
{
    public class MenuMascotas
    {
        /// <summary>
        /// Contiene la informacion a mostrar por consola al usuario.
        /// Es readonly porque solo se le podrá asignar en el constructor estatico la info a mostrar
        /// </summary>
        public static readonly string infoMenu;

        static MenuMascotas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ingrese operación a realizar:");
            sb.AppendLine("0 - Volver al menú principal");
            sb.AppendLine("1 - Alta mascota");
            sb.AppendLine("2 - Baja mascota");
            sb.AppendLine("3 - Modificar mascota");
            sb.AppendLine("4 - Eliminar mascota");
            sb.AppendLine("5 - Listar mascota");
            infoMenu = sb.ToString();
        }
        /// <summary>
        /// Retorna la informacion del menu mascotas en un string
        /// </summary>
        public static string InfoMenu
        {
            get
            {
                return infoMenu;
            }
        }

        public static bool SwitchComando()
        {
            throw new NotImplementedException();
        }
    }
}
