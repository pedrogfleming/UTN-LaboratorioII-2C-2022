using EShop;
using EShop.Excepciones;
using System;
using System.Collections.Generic;

namespace Veterinaria
{
    public static class VeterinariaManager
    {
        private static Dictionary<Mascota, bool> pets;
        /// <summary>
        /// Lista de espera de mascota y si ya fue atendida o no
        /// </summary>
        public static Dictionary<Mascota, bool> Pets { get;}

        static VeterinariaManager()
        {
            Pets = new Dictionary<Mascota,bool>();
            Pets.Add(new Mascota("Raichu", 2, Guid.NewGuid()), false);
            Pets.Add(new Mascota("Copito", 5, Guid.NewGuid()), false);
            Pets.Add(new Mascota("Michi", 12, Guid.NewGuid()), true);
        }
        public static bool AtenderMascota(Mascota m)
        {
            try
            {
                //Chequeo si la mascota existe en la cola
                if (!Pets.ContainsKey(m)) 
                {
                    throw new MascotaInexistenteException("La mascota no está registrada"); 
                }
                //Si la mascota ya esta atendida, retorno false
                if (Pets[m])
                {
                    return false;
                }
                //Si no esta atendida, la marco como atendida
                Pets[m] = true;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
        }
        public static bool AgregarMascotaALaCola(Mascota m)
        {
            //Si la mascota no esta en la cola, la agrego
            if (!Pets.ContainsKey(m))
            {
                Pets.Add(m, false);
                return true;
            }
            else
            {
                //Si la mascota ya esta en la cola, entonces no la agrego y retorno false
                return false;
            }
        }


    }
}
