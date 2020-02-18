using System;

namespace LISKOVRefactor
{
    class Program
    {
        static void Main(string[] args)
        {

            Principal news = new News("Hello to all");
            news.Show();

            Principal radio = new Radio("How are you ?");
            radio.Show();

            Console.ReadKey();
           
        }
    }
}
