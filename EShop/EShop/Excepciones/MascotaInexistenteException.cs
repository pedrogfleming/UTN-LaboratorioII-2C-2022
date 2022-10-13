using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Excepciones
{
    public class MascotaInexistenteException : Exception
    {
        public MascotaInexistenteException(string message) : base(message)
        {
        }

        public MascotaInexistenteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
