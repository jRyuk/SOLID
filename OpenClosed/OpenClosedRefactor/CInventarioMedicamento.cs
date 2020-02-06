using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedRefactor
{
    class CInventarioMedicamento : CBaseInventario
    {
        public CInventarioMedicamento(CProducto cProducto) : base(cProducto)
        {
        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
