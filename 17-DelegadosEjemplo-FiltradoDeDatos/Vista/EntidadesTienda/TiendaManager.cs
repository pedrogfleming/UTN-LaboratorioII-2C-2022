using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTienda
{
    public static class TiendaManager
    {
        public static  MostrarDetalle MostrarDetalle { get; set; }
        public static List<Producto> Productos { get; set; }

        static TiendaManager()
        {
            Productos = new List<Producto>()
            {
                new Producto(Guid.NewGuid(),"Blanca y suave","Toalla", (decimal)220.75),
                new Producto(Guid.NewGuid(),"Antibacterial","Jabon", (decimal)55.25),
                new Producto(Guid.NewGuid(),"Muy caro y re top","Perfume",(decimal)555.99)
            };
        }
    }
}
