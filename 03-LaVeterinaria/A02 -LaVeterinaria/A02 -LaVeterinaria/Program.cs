using Domain;

namespace A02__LaVeterinaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            // https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/A02-veterinaria/
            do
            {
                ConsolaManager.MostrarPorConsola(MenuPrincipal.InfoMenu);
                ConsolaManager.IngresarComando();

            } while (ConsolaManager.Seguir);
        }
    }
}