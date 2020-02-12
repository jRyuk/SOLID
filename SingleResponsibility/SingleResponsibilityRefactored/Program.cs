using System;

namespace SingleResponsibilityRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Jhon", "Developer", 21, 1500);
            Console.WriteLine(employee);
            var taxesManager = new TaxesManager(employee);
            taxesManager.PayTaxes();
            Console.ReadKey();
        }
    }
}
