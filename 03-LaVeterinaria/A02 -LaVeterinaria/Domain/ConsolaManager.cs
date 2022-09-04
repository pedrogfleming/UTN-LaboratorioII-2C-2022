﻿namespace Domain
{
    public static class ConsolaManager
    {
        /// <summary>
        /// Será la última accion realizada por el usuario,
        /// declarada como nulleable dado que al arrancar el programa todavía no ingresó un comando el usuario
        /// </summary>
        private static string? ultimaEntradaPorConsola;
        public static string UltimaEntradaPorConsola { get; set; }
        public static EMenu MenuActual { get; set; }

        /// <summary>
        /// Contiene la informacion a mostrar por consola al usuario del menu actual.
        /// </summary>
        /// 
        public static string infoMenu;
        /// <summary>
        /// Retorna la informacion del menu actual en un string
        /// </summary>
        public static string OpcionesMenuActual
        {
            get
            {
                return infoMenu;
            }
            set
            {
                infoMenu = value;
            }
        }
        /// <summary>
        /// Servirá para saber si el cliente quiere salir del menu actual
        /// Por default, se le asigna true
        /// </summary>
        public static bool Seguir { get; set; } = true;

        /// <summary>
        /// Se mostrara la información por consola al usuario
        /// </summary>
        /// <returns></returns>
        public static void MostrarPorConsola(string info)
        {
            Console.WriteLine(info);
        }
        /// <summary>
        /// Validara que el comando ingresado sea un numero
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool EsComandoValido(string input)
        {
            // out _ se usa porque el TryParse me pide si o si un 2do parametro donde guardar el resultado de la conversion
            // _ se usa para declarar variables que no se van a usar
            // Mas info aca: https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/functional/discards
            return int.TryParse(input.ToString(), out _);
        }
        public static void IngresarComando()
        {
            UltimaEntradaPorConsola = Console.ReadLine();
            if (!string.IsNullOrEmpty(UltimaEntradaPorConsola) && ConsolaManager.EsComandoValido(UltimaEntradaPorConsola))
            {
                SwitchComando();
            }
            else
            {
                Console.WriteLine("Comando invalido\n");
            }
        }

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
                    ConsolaManager.Seguir = false;
                    break;
                case 1:
                    //1 - Menu clientes
                    ConsolaManager.MenuActual = EMenu.Clientes;
                    Console.WriteLine($"\n{MenuActual}\n");
                    ConsolaManager.OpcionesMenuActual = MenuClientes.InfoMenu;
                    ConsolaManager.MostrarPorConsola(MenuClientes.InfoMenu);

                    ConsolaManager.IngresarComando();

                    break;
                case 2:
                    //2 - Menu mascotas
                    ConsolaManager.MenuActual = EMenu.Mascotas;
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
