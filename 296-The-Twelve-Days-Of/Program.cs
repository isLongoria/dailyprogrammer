using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace dailyprogrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> days = new List<string> { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eight", "ninth", "tenth", "eleventh", "twelfth" };
            List<string> numbers = new List<string> {"and a", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
            List<string> gifts = File.ReadAllLines(@"C:\Users\pimaDesktop\Documents\Visual Studio 2015\Projects\dailyprogrammer\296E.txt").ToList();

            for (int i = 0; i < gifts.Count; i++)
            {
                Console.WriteLine("On the {0} day of Christmas\nmy true love sent to me:", days[i]);
                for (int j = i ; j >= 0; j--)
                {
                    if (i == 0)
                        Console.WriteLine("a {0}", gifts[i]);
                    else
                        Console.WriteLine("{0} {1}", numbers[j], gifts[j]);
                    
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
