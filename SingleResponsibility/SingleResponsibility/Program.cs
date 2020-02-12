using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jhon", "Developer", 21, 1500);
            Console.WriteLine(employee);
            employee.PayTaxes();
            Console.ReadKey();
        }
    }
}
