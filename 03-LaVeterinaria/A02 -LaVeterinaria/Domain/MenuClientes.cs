using System.Text;

namespace Domain
{
    public class MenuClientes
    {
        /// <summary>
        /// Contiene la informacion a mostrar por consola al usuario.
        /// Es readonly porque solo se le podrá asignar en el constructor estatico la info a mostrar
        /// </summary>
        public static readonly string infoMenu;
        static MenuClientes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ingrese operación a realizar:");
            sb.AppendLine("0 - Volver al menú principal");
            sb.AppendLine("1 - Alta cliente");
            sb.AppendLine("2 - Baja cliente");
            sb.AppendLine("3 - Modificar cliente");
            sb.AppendLine("4 - Eliminar cliente");
            sb.AppendLine("5 - Listar clientes");
            infoMenu = sb.ToString();
        }
        /// <summary>
        /// Retorna la informacion del menu clientes en un string
        /// </summary>
        public static string InfoMenu
        {
            get
            {
                return infoMenu;
            }
        }

    }
}
