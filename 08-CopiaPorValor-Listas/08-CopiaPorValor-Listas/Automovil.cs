using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Automovil
    {
        public Automovil(string v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public string V1 { get; }
        public int V2 { get; }
    }
}
