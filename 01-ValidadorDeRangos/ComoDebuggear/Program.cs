namespace ComoDebuggear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPerros = 0;
            int totalGatos = 0;
            char deRaza;
            int PerrosDeRaza = 0;
            int GatosDeRaza = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Indique que mascota tiene(perro/gato)");
                string mascota = Console.ReadLine().ToLower();
                Console.WriteLine("Indique si es de raza o no(s/n)");
                char.TryParse(Console.ReadLine().ToLower(),out deRaza);
                switch (mascota)
                {
                    case "perro":
                        totalPerros++;
                        if (deRaza == 's')
                        {
                            PerrosDeRaza++;
                        }
                        break;
                    case "gato":
                        totalGatos++;
                        if (deRaza == 's')
                        {
                            GatosDeRaza++;
                        }
                        break;
                }
            }
            Console.WriteLine($"Total de perros es {totalPerros} y hay {PerrosDeRaza} de raza");
            Console.WriteLine($"Total de Gatos es {totalPerros} y hay {GatosDeRaza} de raza");
        }
    }
}