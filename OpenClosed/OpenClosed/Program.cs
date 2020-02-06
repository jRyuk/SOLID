using System;
using System.Collections.Generic;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            var productos = new List<CProducto>
            {
                new CProducto("Papas",1,12.5),
                new CProducto("Analgesicos",2,23.40),
                new CProducto("Tomate",1,30),
                new CProducto("Manzanas",1,25),
                new CProducto("Antibiotico",2,89),
                new CProducto("Antiacido",2,43),
            };

            var miTienda = new CTienda(productos);
            miTienda.CalcularInventario();
        }
    }
}
