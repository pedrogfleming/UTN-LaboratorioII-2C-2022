using System.Linq;

namespace _01_ValidadorDeRangos
{
    public class Program
    {
        // Consigna: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/estaticos/Ejercicios/I01-validador-rangos/
        // Version alternativa usando arrays y métodos Min,Max y Average
        static void Main(string[] args)
        {
            int totalNumeros = 0;
            //Declaro un array y lo inicializo con un largo de 10 elementos con un valor de 0 cada uno
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un  número");
                string input = Console.ReadLine();
                int numeroIngresado = 0;
                bool esEntero = int.TryParse(input, out numeroIngresado);
                while (!esEntero || !Validador.Validar(numeroIngresado,-100,100))
                {
                    Console.WriteLine("Error, ingrese unicamente un número entre -100 y 100");
                    input = Console.ReadLine();
                    esEntero = int.TryParse(input, out numeroIngresado);
                }
                numeros[i] = numeroIngresado;
                totalNumeros++;
            }
            // El $ delante de las comillas y el uso de {posicion} se llama interpolación de string
            // Se usa para no tener que concatenar el valor de las variables y hacer mas corto el string a mostrar por consola
            //´concatenando se vería así:
            // Console.WriteLine($"El número en la posición "+posicion+" es "+item);
            int posicion = 0;
            foreach (int item in numeros)
            {
                Console.WriteLine($"El número en la posición {posicion} es {item}");
                posicion++;
            }
            //Usando la libreria LINQ, puedo acceder a métodos de instancia como Max,Min, Average
            //Linq nos provee de métodos para recorrer arrays y colecciones de manera sencilla y facil
            //Documentación oficial sobre LINQ https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/linq/
            //Videos de youtube demostrando sus funcionalidades básicas:
            // https://www.youtube.com/watch?v=JNeFB_2YHrc
            // https://www.youtube.com/watch?v=JtGsbKQqJbo
            //De esta manera podemos simplificar nuestro código sin armar el foreach y realizar la lógica de búsqueda del mayor o menor
            Console.WriteLine($"El número más grande es {numeros.Max()}");
            Console.WriteLine($"El número más chico es {numeros.Min()}");
            Console.WriteLine($"El promedio de los números ingresados es {numeros.Average()}");
        }
    }
}