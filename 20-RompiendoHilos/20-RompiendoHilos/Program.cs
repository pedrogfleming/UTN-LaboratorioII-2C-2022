using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _20_RompiendoHilos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplo 1
            Task t1 = new Task(() =>
            {
                try
                {
                    throw new Exception("Desde el hilo 1 tiro la excepcion");
                }
                catch (Exception)
                {
                    Console.WriteLine("Desde adentro del catch 1");
                }
            });
            Task t2 = new Task(() =>
            {
                try
                {
                    throw new Exception("Desde el hilo 2 tiro la excepcion");
                }
                catch (Exception)
                {

                    Console.WriteLine("Desde adentro del catch 2");
                }
            });

            List<Task> tasks = new List<Task>();
            tasks.Add(t1);
            tasks.Add(t2);
            t1.Start();
            t2.Start();
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("Fin del programa");
            #endregion

            #region Ejemplo CancellToken 
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            int i = 0;
            Task tA = new Task(() =>
            {

                while (!tokenSource.IsCancellationRequested)
                {
                    Console.WriteLine($"T1 - iteracion {i} dentro del t1");
                    i++;
                }
            }, token);
            Task tB = new Task(() =>
            {
                while (i < 10)
                {
                    Console.WriteLine($"T2 - Todavia no puedo cancelar t1, i= {i}");
                }
                Console.WriteLine($"Se cancela T1, i = {i}");
                tokenSource.Cancel();
            });

            List<Task> tasks2 = new();
            tasks2.Add(tA);
            tasks2.Add(tB);
            foreach (Task t in tasks)
            {
                t.Start();
            }

            Task.WaitAll(tasks2.ToArray());

            #endregion

        }
    }
}
