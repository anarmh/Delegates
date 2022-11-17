using System;
using System.Collections.Generic;
using System.Text;

namespace Person_type_from_List_with_delegate.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }

        public Person(string name, string surname, double salary, string address)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Address = address;
        }

    }
}
