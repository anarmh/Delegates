using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        //public delegate bool CheckNums(int num);
        //public delegate void ChangeString(string str,int age);
        //public delegate int StringLength(string str);
        static void Main(string[] args)
        {
            #region Predicate
            //int? a = null;
            //Console.WriteLine(a);

            //int[] arr = { 1, 2, 11, 22, 34, 17, 45, 56 };
            //Console.WriteLine(Sum(CheckOddNums,arr));
            //Console.WriteLine(Sum(CheckEvenNums,arr));
            //Console.WriteLine(Sum(CheckGreaterThanFour,arr));

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,21,63,42 };
            //var result= list.FindAll(m => m % 2 != 0 && m > 4);
            // Console.WriteLine(result.Count);
            //Console.WriteLine(SumNumbersDividedby3and7(CheckNumbersDividedby3and7,list));

            //Console.WriteLine(list.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m => m));
            #endregion
            #region Action
            //CheckString(StringToUpper, "anar");
            //CheckString(StringToLower, "ANAR");

            //ChangeString changeString = StringToLower;
            //changeString += StringToUpper;
            //changeString.Invoke("Anar", 35);

            //changeString += (str, age) => Console.WriteLine(str.ToLower() + " Age: " + age);

            //Action<string, int> action = StringToLower;
            //action.Invoke("Anar", 35);


            //CheckPower(CalculatePower, 3, 4);

            //Action<int, int> func = CalculatePower;
            //func.Invoke(4, 3);
            #endregion

            //ShowStringLength(GetStringLength, "Anar");

            //Func<string, int> func = GetStringLength;
            //var result=func.Invoke("Anar");
            //Console.WriteLine(result);

            Func<int, int> func = CalculateFactorial;
           var result= func.Invoke(6);
            Console.WriteLine(result);

        }


        public static int CalculateFactorial(int num)
        {
            int mult = 1;
            for (int i = num; i > 1; i--)
            {
                mult *= i;
            }
            return mult;
        }

        public static int CheckFactorial(Func<int,int> func,int num)
        {
            return func(num);
        }






        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}

        //public static int ShowStringLength(Func <string,int> func,string word)
        //{
        //    return func(word);
        //}






        //public static void CalculatePower(int num,int power)
        //{
        //    Console.WriteLine(Math.Pow(num, power));
        //}
        //public static void CheckPower(Action<int,int> func,int num,int pow)
        //{
        //    func(num, pow);
        //}

        //public static void StringToLower(string str,int age)
        //{
        //    Console.WriteLine(str.ToLower()+" Age: "+age);
        //}

        //public static void StringToUpper(string str, int age)
        //{
        //    Console.WriteLine(str.ToUpper()+" Age: "+age);
        //}

        //public static void CheckString(Action<string,int> func,string str,int age)
        //{
        //    func(str,age);
        //}





        //public static bool CheckNumbersDividedby3and7(int num)
        //{
        //    return num % 3 == 0 && num % 7 == 0;
        //}

        //public static int SumNumbersDividedby3and7(Predicate<int> predicate,List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //            sum += item;
        //    }
        //    return sum;
        //}


        //public static bool CheckOddNums(int number)
        //{
        //    return number % 2 != 0;
        //}
        //public static bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}
        //public static bool CheckGreaterThanFour(int number)
        //{
        //    return number > 5 ;
        //}



        //public static int Sum(Predicate<int> predicate,int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item)) 
        //        sum += item;

        //    }
        //    return sum;
        //}

        //public static int SumEvenNums(CheckNums predicate, int [] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item)) 
        //        sum += item;
        //    }
        //    return sum;
        //}

        ////public static int SumGreaterThanFour(CheckNums predicate,int [] arr)
        ////{
        ////    int sum = 0;
        ////    foreach (var item in arr)
        ////    {
        ////        if (predicate(item) ) 
        ////        sum += item;
        ////    }
        ////    return sum;
        ////}

        //public static string GetId(int? id)
        //{
        //if(id is null)
        //{
        //    return "";
        //}
        //return "";
        //}

    }
}
