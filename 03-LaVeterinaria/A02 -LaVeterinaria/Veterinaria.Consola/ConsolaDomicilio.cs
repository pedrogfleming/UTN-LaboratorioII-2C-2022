using Domain;
using Spectre.Console;

namespace Veterinaria.Consola
{
    /// <summary>
    /// Clase usada para manejar la interacion por consola con el usuario en todo lo relacionado a la clase Domicilio
    /// Se podria decir que es el frontend de la aplicacion de consola
    /// </summary>
    public class ConsolaDomicilio
    {
        /// <summary>
        /// Pedira por consola los datos del domicilio del cliente
        /// Se validara que la ciudad,calle seam solo letras,
        /// que la altura sean solo numeros,
        /// y que el departamento sea numeros o letras
        /// </summary>
        /// <returns>La instancia de Domicilio con los datos validados</returns>
        public static Domicilio PedirDomicilio()
        {
            //Instancio un domicilio vacio que ire llenando con los datos validados que ira ingresando el usuario
            Domicilio domicilio = new();
            domicilio.Ciudad = ConsolaDomicilio.PedirCiudad();
            domicilio.Calle = ConsolaDomicilio.PedirCalle();
            domicilio.Altura = ConsolaDomicilio.PedirAltura();
            domicilio.Piso = ConsolaDomicilio.PedirPiso();
            domicilio.Departamento = ConsolaDomicilio.PedirDepartamento();
            return domicilio;
        }
        public static string PedirDepartamento()
        {
            string input = AnsiConsole.Ask<string>("Ingrese [blue]departamento[/]");
            while (!input.All(char.IsLetterOrDigit))
            {
                input = AnsiConsole.Ask<string>($"{input} no es departamento valido. Ingrese nuevamente [blue]departamento[/]");
            }
            return input;
        }

        public static int? PedirPiso()
        {
            int input = AnsiConsole.Ask<int>("Ingrese [blue]piso[/]");
            while (input <= 0)
            {
                input = AnsiConsole.Ask<int>($"{input} no es un piso valido. Ingrese nuevamente [blue]piso[/]");
            }
            return input;
        }
        public static int? PedirAltura()
        {
            int inputNumerico = AnsiConsole.Ask<int>("Ingrese [blue]altura[/]");
            while (inputNumerico <= 0)
            {
                inputNumerico = AnsiConsole.Ask<int>($"{inputNumerico} no es una altura valida. Ingrese nuevamente [blue]altura[/]");
            }
            return inputNumerico;
        }
        public static string PedirCalle()
        {
            string input = AnsiConsole.Ask<string>("Ingrese [blue]calle[/]");
            while (!input.All(char.IsLetterOrDigit))
            {
                input = AnsiConsole.Ask<string>($"{input} no es una calle valida. Ingrese nuevamente [blue]calle[/]");
            }
            return input;
        }
        public static string PedirCiudad()
        {
            string input = AnsiConsole.Ask<string>("Ingrese [blue]ciudad[/]");
            while (!input.All(char.IsLetter))
            {
                input = AnsiConsole.Ask<string>($"{input} no es una ciudad valida. Ingrese nuevamente [blue]ciudad[/]");
            }
            return input;
        }
    }
}
