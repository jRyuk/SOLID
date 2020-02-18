using System;

namespace LISKOV
{
    class Program
    {
        static void Main(string[] args)
        {
            var news = new News("Hello to all");
            news.Show();

            var radio = new Radio("How are you?");
            radio.Show();

            News replace = new Radio("We are testing");
            replace.Show();

            Console.ReadKey();
        }
    }
}
