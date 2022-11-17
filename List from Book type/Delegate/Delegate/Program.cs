using Delegate.Models;
using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            list.Add(new Book{ Name= "Isgendername", Author= "Nizami" });
            list.Add(new Book{ Name = "Xosrov ve Shirin", Author="Nizami" });
            list.Add(new Book{ Name = "Ferhad ve sirin", Author="Fuzuli" });
            list.Add(new Book { Name = "Shikayetname", Author="Fuzuli" });

           
            ShowBookAuthor(CheckBookAuthor, list);
            
        }

        public static bool CheckBookAuthor(string author)
        {
            if (author == "Nizami")
                return true;
            return false;
        }   
        public static void ShowBookAuthor(Predicate<string> predicate,List<Book> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (predicate(item.Author))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{item.Name} {item.Author}");
                }

            }
            Console.WriteLine("Authoru Nizami olanlarin sayi: "+" "+count);
        }
    }
}
