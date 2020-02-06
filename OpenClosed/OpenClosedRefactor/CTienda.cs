using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedRefactor
{
    class CTienda
    {
        public List<CBaseInventario> productos;
        public CTienda(List<CBaseInventario> pProductos)
        {
            productos = pProductos;
        }


        public void CalcularInventario()
        {
            double total = 0;
            foreach(var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto.Producto);
                total += producto.Producto.Precio;
            }

            Console.WriteLine($"El total en inventario es {total}");
        }

    }
}
