using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    public class Employee
    {
        public int Age { get; set; }
        public int Salary { get; set; }
        public Employee(int age,int salary)
        {
            Age = age;
            Salary = salary;
        }
    }
}
