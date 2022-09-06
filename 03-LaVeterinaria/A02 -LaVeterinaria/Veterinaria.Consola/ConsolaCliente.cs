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
            while (!apellido.All(char.IsLetter))
            {
                apellido = AnsiConsole.Ask<string>($"{apellido} no es un apellido valido. Ingrese nuevamente [green]Apellido[/] del cliente");
            }
            return apellido;
        }
        /// <summary>
        /// Pedira por consola el telefono del cliente
        /// Se validara que sea un numero telefonico(solo numeros)
        /// Si no es valido, se le pedira que lo vuelva a ingresar
        /// </summary>
        /// <returns>El telefono validado del cliente</returns>
        private static string PedirTelefonoCliente()
        {
            string telefono = AnsiConsole.Ask<string>("Ingrese [yellow]Telefono[/] del cliente");
            //Validacion de que sean unicamente letras lo que ingreso el usuario
            while(!telefono.All(char.IsDigit))
            {
                telefono = AnsiConsole.Ask<string>($"{telefono} no es un telefono valido. Ingrese nuevamente [green]Apellido[/] del cliente");
            }
            return telefono;
        }
    }
}
