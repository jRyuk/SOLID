using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRefactored
{
    class Employee
    {
        private string _name;

        private string _workPosition;

        private int _age;

        private decimal _salary;

        public string Name { get => _name; set => _name = value; }
    

        public decimal Salary { get => _salary; set => _salary = value; }


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


      
    }
}
