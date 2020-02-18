using System;
using System.Collections.Generic;
using System.Text;

namespace LISKOV
{
    public class Radio : News
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
