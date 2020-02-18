using System;
using System.Collections.Generic;
using System.Text;

namespace LISKOV
{
    public class News
    {
        protected string message;

        public News(string message)
        {
           this.message = message;
        }

        public virtual void Show()
        {
            Console.WriteLine($"From news: {message}");
        }
    }
}
