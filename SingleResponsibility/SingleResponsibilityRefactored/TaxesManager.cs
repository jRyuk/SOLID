using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRefactored
{
    class TaxesManager
    {
        private readonly Employee _employee;

        public TaxesManager(Employee employee)
        {
            _employee = employee;
        }

        private decimal GetTaxes()
        {

            return _employee.Salary * 0.35M;
        }

        public void PayTaxes()
        {
            decimal taxes = GetTaxes();

            Console.WriteLine($"It has been paid ${taxes} in taxes, by {_employee.Name}");
        }
    }
}
