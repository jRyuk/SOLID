﻿using System;
using System.Collections.Generic;

namespace OpenClosedRefactor
{
    class Program
    {

        static void Main(string[] args)
        {
            var productos = new List<CBaseInventario>
            {
                new CInventarioAlimento( new CProducto("Papas",1,12.5)),
                  new CInventarioMedicamento( new CProducto("Analgesicos",2,23.40)),
                  new CInventarioAlimento( new CProducto("Tomate",1,30)),
                  new CInventarioAlimento( new CProducto("Manzanas",1,25)),
               new CInventarioMedicamento( new CProducto("Antibiotico",2,89)),
               new CInventarioMedicamento(  new CProducto("Antiacido",2,43)),
            };

            var miTienda = new CTienda(productos);
            miTienda.CalcularInventario();
        }
    }
}
