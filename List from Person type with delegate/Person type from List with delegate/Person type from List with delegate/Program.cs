using Person_type_from_List_with_delegate.Models;
using System;
using System.Collections.Generic;

namespace Person_type_from_List_with_delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();
            list.Add(new Person("Anar", "Huseynov", 800, "5 mkr"));
            list.Add(new Person("Cavid", "Rzayev", 800, "11 mkr"));
            list.Add(new Person("Rafael", "Babaverdiyev", 600, "26-ci mehelle"));
            list.Add(new Person("Xeyyam", "Salmanov", 3000, "Hovsan"));
            list.Add(new Person("Samir", "Ehmedov", 2000, "13 mkr"));
            

            ShowSalaryPersonMoreThanThousand(CheckSalaryPersonMoreThanThousand, list);
        }


        public static bool CheckSalaryPersonMoreThanThousand(double salary)
        {
            return salary > 1000;
        }

        public static void ShowSalaryPersonMoreThanThousand(Predicate<double> predicate, List<Person> list)
        {
            foreach (var item in list)
            {
                if(predicate(item.Salary))
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Salary} {item.Address}");
            }
           
        }
    }
}
