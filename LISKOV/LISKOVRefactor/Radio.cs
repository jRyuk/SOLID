using System;
using System.Collections.Generic;
using System.Text;

namespace LISKOVRefactor
{
    public class Radio : Principal
    {
        public Radio(string message) : base(message)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"From radio: {message}");
        }
    }
}
