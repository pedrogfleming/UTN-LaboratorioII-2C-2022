using System;

namespace Entidades
{
    public static class Mockeador
    {
        /// <summary>
        /// El generador de numeros aleatorios
        /// </summary>
        private static Random _rand;

        static Mockeador()
        {
            Mockeador._rand = new();
        }
        /// <summary>
        /// Asignara de manera aleatoria la cantidad de km por dia
        /// </summary>
        /// <param name="semana">Un array de float representando cada elemento un dia de la semana y su valor la cantidad de kms recorridos en ese dia</param>
        public static void MockearkmPorSemanaConductor(float[] semana)
        {
            for (int i = 0; i < semana.Length; i++)
            {
                semana[i] = _rand.Next(0, 100);
            }
        }


}
}
