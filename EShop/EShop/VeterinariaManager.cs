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
            Pets.Add(new Mascota("Raichu",2, Guid.NewGuid()),false);
            Pets.Add(new Mascota("Copito", 5, Guid.NewGuid()),false);
            Pets.Add(new Mascota("Michi", 12, Guid.NewGuid()), true);
        }
        public static bool AtenderMascota(Mascota m)
        {
            try
            {
                //Chequeo si la mascota ya fue atendida
                if (!Pets.ContainsKey(m)) { throw new MascotaInexistenteException("La mascota no está registrada"); }
                if (Pets[m])
                {
                    return false;
                }
                Pets[m] = true;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool AgregarMascotaALaCola(Mascota m)
        {
            if (!Pets.ContainsKey(m))
            {
                Pets.Add(m, false);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
