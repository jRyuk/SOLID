using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedRefactor
{
    abstract class CBaseInventario
    {
        protected CProducto producto;

        public CProducto Producto { get => producto; set => producto = value; }

        public CBaseInventario(CProducto cProducto)
        {
            producto = cProducto;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract double CalcularProducto();
    }
}
