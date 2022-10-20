using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador
{
    public class ContadorDeNumeros
    {
        public IEnumerable<int> filtrarPositivos(IEnumerable<int> nums)
        {
            return nums.Where(x => x > 0);
        }
    }
}
