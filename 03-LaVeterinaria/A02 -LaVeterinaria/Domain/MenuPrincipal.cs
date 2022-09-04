using System.Text;

namespace Domain
{
    /// <summary>
    /// Definimos una clase estatica para manejar la interaccion del usuario con la aplicacion
    /// </summary>
    public static class MenuPrincipal
    {

        /// <summary>
        /// Será la última accion realizada por el usuario,
        /// declarada como nulleable dado que al arrancar el programa todavía no ingresó un comando el usuario
        /// </summary>
        private static string? ultimaEntradaPorConsola;


        /// <summary>
        /// Contiene la informacion a mostrar por consola al usuario.
        /// Es readonly porque solo se le podrá asignar en el constructor estatico la info a mostrar
        /// </summary>
        public static readonly string infoMenu;

        static MenuPrincipal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ingrese operación a realizar:");
            sb.AppendLine("0 - Volver al menu anterior");
            sb.AppendLine("1 - Menu clientes");
            sb.AppendLine("2 - Menu mascotas");
            sb.AppendLine("3 - Ver clientes y mascotas");
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
        public static string UltimaEntradaPorConsola { get; set; }
        /// <summary>
        /// Realiza la accion solicitada por el usuario en el menu
        /// </summary>
        private static void SwitchComando()
        {
            //Asigno por default un nro negativo para agregar una validacion más de comando invalido
            int comando = -1;
            int.TryParse(UltimaEntradaPorConsola, out comando);
            switch (comando)
            {
                case 0:
                    //0 - Volver al menur anterior
                    ConsolaManager.MenuActual = EMenu.;
                    break;
                case 1:
                    //1 - Menu clientes                    
                    Console.WriteLine("\nMenu clientes\n");
                    ConsolaManager.MostrarPorConsola(MenuClientes.InfoMenu);
                    MenuPrincipal.IngresarComando();

                    break;
                case 2:
                    //2 - Menu mascotas                    
                    Console.WriteLine("Menu mascotas");
                    break;
                case 3:
                    //3 - Ver clientes y mascotas
                    Console.WriteLine("Mostrar clientes y mascotas");
                    break;
                default:
                    //Comando invalido
                    Console.WriteLine("Comando invalido\n");
                    break;
            }
        }
    }
}
