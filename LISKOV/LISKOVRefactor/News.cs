using System;
using System.Collections.Generic;
using System.Text;

namespace LISKOVRefactor
{
    public class News : Principal
    {
        public News(string message) : base(message)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"From news: {message}");
        }
    }
}
