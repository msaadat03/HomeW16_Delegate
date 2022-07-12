using System;
using System.Collections.Generic;

namespace HomeW16_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> name = new List<string>() { "Saadat", "Fidan", "Cavid" };
            Cheking(CheckName, name);
        }

        public static bool CheckName(string name)
        {
            return name != "Cavid";
        }

        public static void Cheking(Predicate<string> predicate, List<string> names)
        {
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}







//Cheking(CheckName, name);
