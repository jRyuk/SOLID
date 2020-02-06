using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedRefactor
{
    class CInventarioAlimento : CBaseInventario
    {

        public CInventarioAlimento(CProducto cProducto) : base(cProducto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;

            return producto.Precio;
        }
    }
}
