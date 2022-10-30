using EShop.Excepciones;
using System;
using System.Data.Common;

namespace Veterinaria
{
    public class Mascota
    {
        public Mascota(string nombre, int edad,Guid id)
        {
            try
            {
                if (!EdadValida(edad))
                {
                    throw new EdadInvalidaException("La edad no puede ser menor a cero");
                }
                Nombre = nombre;
                Edad = edad;
                Id = id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Guid Id { get; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public static bool operator ==(Mascota m1,Mascota m2)
        {
            return m1.Id == m2.Id ||
                (m1.Nombre == m2.Nombre && m1.Edad == m2.Edad);
        }
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        private bool EdadValida(int edad)
        {
            if(edad < 0)
            {
                return false;                
            }
            return true;
        }
    }
}