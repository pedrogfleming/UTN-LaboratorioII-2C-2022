using Domain;
using System.Text;
using Veterinaria.Consola.Menues.Enums;
using Veterinaria.Servicios;

namespace Veterinaria.Consola.Menues
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

        /// <summary>
        /// Realiza la accion solicitada por el usuario en el menu
        /// </summary>
        public static bool SwitchComando()
        {
            //Asigno por default un nro negativo para agregar una validacion más de comando invalido
            int comando = -1;
            int.TryParse(ConsolaManager.UltimaEntradaPorConsola, out comando);
            switch (comando)
            {
                case 0:
                    //0 - Volver al menu principal
                    ConsolaManager.MenuActual = EMenu.Principal;
                    break;
                case 1:
                    //1 - Alta cliente
                    Cliente clienteIngresado = ConsolaCliente.PedirDatosCliente();
                    clienteIngresado.Domicilio = ConsolaDomicilio.PedirDomicilio();
                    return ServicioCliente.Alta(clienteIngresado);
                case 2:
                    //2 - Baja cliente
                    break;
                case 3:
                    //3 - Modificar cliente
                    break;
                case 4:
                    //4 - Eliminar cliente
                    break;
                case 5:
                    //5 - Listar clientes
                default:
                    //Comando invalido
                    Console.WriteLine($"{ConsolaManager.UltimaEntradaPorConsola} no es un comando valido\n");
                    break;
            }
            return false;
        }

    }
}
