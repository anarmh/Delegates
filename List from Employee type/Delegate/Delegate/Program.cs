using Delegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(35, 800));
            list.Add(new Employee(45, 1000));
            list.Add(new Employee(50, 2000));
            list.Add(new Employee(32, 1200));


            ShowEmployeeNumericalMean(CheckEmployeeNumericalMean, list); 
        }

        public static bool CheckEmployeeNumericalMean(int age)
        {
            return age > 20 && age < 40;
        }
        public static void ShowEmployeeNumericalMean(Predicate<int> predicate,List<Employee> list)
        {
            int count = 0;
            int totalSalary = 0;
            foreach (var item in list)
            {
                
                if (predicate(item.Age))
                {
                    count++;
                    totalSalary += item.Salary;
                }
            }
            Console.WriteLine(totalSalary/count);

        }


    }
}
