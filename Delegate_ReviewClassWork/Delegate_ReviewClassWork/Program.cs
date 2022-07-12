using System;
using System.Collections.Generic;

namespace Delegate_ReviewClassWork
{
    class Program
    {
        public delegate bool CheckNums(int num);

        public delegate void ChangeString(string str);

        public delegate int StringLength(string str);
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var result = numbers.FindAll(m => m > 7);
            var result2 = numbers.FindAll(CheckMoreThanFive);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Test(StringToUpper, "Seadet");

            ChangeString change = new ChangeString(StringToUpper);
            change.Invoke("Seadet");

            Action<string> action = StringToUpper;
            action += StringToLower;
            action("Seadet");

            Console.WriteLine(Test(StrLength, "Seadet"));

        }

        public static int Test(StringLength func, string str)
        {
            return func(str);
        }

        public static void StringToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void StringToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }



        public static int StrLength(string str)
        {
            return str.Length;
        }

       

        public static void Test(ChangeString func, string str)
        {
            func(str);
        }

        public static bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool CheckMoreThanFive(int number)
        {
            return number > 7;
        }


        public static int Sum(CheckNums func, int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (func(item))
                {
                    sum += item;
                }
            }
            return sum;
        }

        public static int Sum(Predicate<int> predicate, int[] nums)
        {
            var sum = 0;

            foreach (var item in nums)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
  }
