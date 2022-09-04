namespace EjPropiedades
{
    internal class Program
    {
        public class Auto
        {
            public int peso;
            public int Peso { get; set; }
        }
        static void Main(string[] args)
        {
            Auto a1 = new Auto() { peso = 45 };
            Console.WriteLine(a1.peso);
            a1.Peso = 2;
            Console.WriteLine(a1.Peso);
        }
    }
}