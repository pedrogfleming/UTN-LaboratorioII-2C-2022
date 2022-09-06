using Spectre.Console;
using Domain;

namespace Veterinaria.Consola
{
    /// <summary>
    /// Clase usada para manejar la interacion por consola con el usuario en todo lo relacionado a la clase Cliente
    /// Se podria decir que es el frontend de la aplicacion de consola
    /// </summary>
    public static class ConsolaCliente
    {
        /// <summary>
        /// Se le pedira los datos completos de cliente a un usuario
        /// </summary>
        /// <returns>El cliente instanciado con los datos completos</returns>
        public static Cliente PedirDatosCliente()
        {
            return new Cliente()
            {
                Nombre = PedirNombreCliente(),
                Apellido = PedirApellidoCliente(),
                Domicilio = PedirDomicilioCliente(),
                Telefono = PedirTelefonoCliente()
            };
        }
        /// <summary>
        /// Pedira por consola el nombre del cliente
        /// Se validara que sea un nombre(solo letras)
        /// Si no es valido, se le pedira que lo vuelva a ingresar
        /// </summary>
        /// <returns>El nombre valido del cliente</returns>
        private static string PedirNombreCliente()
        {
            string nombre = AnsiConsole.Ask<string>("Ingrese [green]Nombre[/] del cliente");
            while (!nombre.All(char.IsLetter))
            {
                nombre = AnsiConsole.Ask<string>($"{nombre} no es un nombre valido.\nIngrese [green]Nombre[/] del cliente");
            }
            return nombre;
        }
        /// <summary>
        /// Pedira por consola el apellido del cliente
        /// Se validara que sea un apellido(solo letras)
        /// Si no es valido, se le pedira que lo vuelva a ingresar
        /// </summary>
        /// <returns>El apellido valido del cliente</returns>
        private static string PedirApellidoCliente()
        {
            string apellido = AnsiConsole.Ask<string>("Ingrese [green]Apellido[/] del cliente");
            //Validacion de que sean unicamente letras lo que ingreso el usuario
            if (apellido.All(char.IsLetter))
            {
                return apellido;
            }
            return default;
        }
        /// <summary>
        /// Pedira por consola el telefono del cliente
        /// Se validara que sea un numero telefonico(solo numeros)
        /// Si no es valido, se le pedira que lo vuelva a ingresar
        /// </summary>
        /// <returns>El telefono validado del cliente</returns>
        private static string PedirTelefonoCliente()
        {
            string telefono = AnsiConsole.Ask<string>("Ingrese [green]Apellido[/] del cliente");
            //Validacion de que sean unicamente letras lo que ingreso el usuario
            while(!telefono.All(char.IsDigit))
            {
                return telefono;
            }
            return default;
        }
        /// <summary>
        /// Pedira por consola los datos del domicilio del cliente
        /// Se validara que la ciudad,calle seam solo letras,
        /// que la altura sean solo numeros,
        /// y que el departamento sea numeros o letras
        /// </summary>
        /// <returns>La instancia de Domicilio con los datos validados</returns>
        private static Domicilio PedirDomicilioCliente()
        {
            //Instancio un domicilio vacio que ire llenando con los datos validados que ira ingresando el usuario
            Domicilio domicilio = new();
            string input = AnsiConsole.Ask<string>("Ingrese [blue]ciudad[/]");
            while (!input.All(char.IsLetter))
            {
                input = AnsiConsole.Ask<string>($"{input} no es una ciudad valida. Ingrese nuevamente [blue]ciudad[/]");
            }
            domicilio.Ciudad = input;
            input = AnsiConsole.Ask<string>("Ingrese [blue]calle[/]");
            while (!input.All(char.IsLetterOrDigit))
            {
                input = AnsiConsole.Ask<string>($"{input} no es una calle valida. Ingrese nuevamente [blue]calle[/]");
            }
            domicilio.Calle = input;
            int altura = AnsiConsole.Ask<int>("Ingrese [blue]altura[/]");
            while (altura <= 0)
            {
                input = AnsiConsole.Ask<string>($"{input} no es una altura valida. Ingrese nuevamente [blue]altura[/]");
            }
            domicilio.Altura = altura;
            input = AnsiConsole.Ask<string>("Ingrese [blue]departamento[/]");
            while (!input.All(char.IsLetterOrDigit))
            {
                input = AnsiConsole.Ask<string>($"{input} no es departamento valido. Ingrese nuevamente [blue]departamento[/]");
            }
            domicilio.Departamento = input;
            return domicilio;
        }
    }
}
