using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    class Employee
    {
        private string _name;

       private string  _workPosition;

        private int _age;

        private decimal _salary;

        public Employee(string name, string workPosition, int age, decimal salary)
        {
            _name = name;
            _workPosition = workPosition;
            _age = age;
            _salary = salary;
        }

        public override string ToString()
        {
            return $"{_name} {_workPosition} {_age} {_salary}";
        }


        private decimal GetTaxes() {

            return _salary * 0.35M;
        }

        public void PayTaxes()
        {
            decimal taxes = GetTaxes();

            Console.WriteLine($"It has been paid {taxes} in taxes, by {_name}");
        }
    }
}
