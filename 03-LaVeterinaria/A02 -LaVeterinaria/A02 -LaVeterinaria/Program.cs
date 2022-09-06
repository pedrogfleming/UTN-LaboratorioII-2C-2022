using Domain;
using Veterinaria.Consola;
using Veterinaria.Consola.Menues;
using Veterinaria.Consola.Menues.Enums;

namespace A02__LaVeterinaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            // https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/A02-veterinaria/
            do
            {
                bool resultado = false;
                ConsolaManager.IngresarComando();
                switch (ConsolaManager.MenuActual)
                {
                    
                    case EMenu.Principal:
                        ConsolaManager.MostrarPorConsola(MenuPrincipal.InfoMenu);
                        if (!ConsolaManager.IngresarComando()) { ConsolaManager.MostrarPorConsola($"{ConsolaManager.UltimaEntradaPorConsola} no es un comando valido\n"); }
                        resultado = MenuPrincipal.SwitchComando();
                        break;
                    case EMenu.Clientes:
                        ConsolaManager.MostrarPorConsola(MenuClientes.InfoMenu);
                        if (!ConsolaManager.IngresarComando()) { ConsolaManager.MostrarPorConsola($"{ConsolaManager.UltimaEntradaPorConsola} no es un comando valido\n"); }
                        resultado = MenuClientes.SwitchComando();
                        break;
                    case EMenu.Mascotas:
                        ConsolaManager.MostrarPorConsola(MenuMascotas.InfoMenu);
                        if (!ConsolaManager.IngresarComando()) { ConsolaManager.MostrarPorConsola($"{ConsolaManager.UltimaEntradaPorConsola} no es un comando valido\n"); }
                        resultado = MenuMascotas.SwitchComando();
                        break;
                }
                if (resultado) { ConsolaManager.MostrarPorConsola("Accion realizada con exito"); }
                else { ConsolaManager.MostrarPorConsola("No se pudo realizar la accion solicitada. Elija nuevamente una opcion"); }
            } while (ConsolaManager.Seguir);
            ConsolaManager.MostrarPorConsola("Saliendo de la aplicacion...");
        }
    }
}