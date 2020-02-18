using System;
using System.Collections.Generic;
using System.Text;

namespace LISKOVRefactor
{
    public abstract class Principal
    {
        protected string message;

        public Principal(string message)
        {
            this.message = message;
        }

        public abstract void Show();

    }
}
