using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class CTienda
    {
        private List<CProducto> productos;

        public CTienda (List<CProducto> cProductos)
        {
            this.productos = cProductos;
        }

        public void CalcularInventario()
        {
            double total = 0;
            //foreach(var producto in productos)
            //{
            //    Console.WriteLine(producto);
            //    total += producto.Precio;
            //}

            foreach(CProducto producto in productos)
            {
                if(producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.8;
                    Console.WriteLine(producto);
                   
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 1.2;
                    Console.WriteLine(producto);
                }

                total += producto.Precio;
            }

            Console.WriteLine($"El total en inventario es: {total}");
        }
    }
}
