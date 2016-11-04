using System;
using System.Collections.Generic;
using System.Linq;

namespace KaprekarRoutine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Description
            LargestDigit(1234);
            LargestDigit(3253);
            LargestDigit(9800);
            LargestDigit(3333);
            LargestDigit(120);

            //Bonus 1
            SortDigitList(SortDirection.Descending, 1234);
            SortDigitList(SortDirection.Descending, 3253);
            SortDigitList(SortDirection.Descending, 9800);
            SortDigitList(SortDirection.Descending, 3333);
            SortDigitList(SortDirection.Descending, 120);

            //Bonus 2
            Kaprekar(6589);
            Kaprekar(5455);
            Kaprekar(6174);

            Console.ReadKey();
        }

        public enum SortDirection
        {
            Ascending,
            Descending
        }

        public static void LargestDigit(int number)
        {
            // Method to return the largest digit. Solves challenge in the description.
            List<int> digitList = NumberToList(number);
            if(digitList.Count() > 0)
                Console.WriteLine("(" + number.ToString() + ")" + " " + digitList.Max());
        }

        public static List<int> NumberToList(int number)
        {
            List<int> digitList = new List<int>();
            string numberString = number.ToString();
            int numberLength = numberString.Length;
            if (numberLength > 4)
            {
                Console.WriteLine("4 digits max.");
                return digitList;
            }
            else if (numberLength < 4)
            {
                numberString = number.ToString("0000");
            }

           
            foreach (char c in numberString.ToCharArray())
            {
                int digit = Convert.ToInt32(c.ToString());
                digitList.Add(digit);
            }
            return digitList;
        }

        public static string SortDigitList(SortDirection Sort, int number)
        {
            // Method to sort the given number either ascending or descending. Solves challenge in Bonus 1.
            List<int> digitList = NumberToList(number);
            List<string> digitStringList = new List<string>();
            string numberString="";
            digitList.Sort();
            if(Sort == SortDirection.Descending)
                digitList.Reverse();
            foreach(int digit in digitList)
            {
                numberString += digit.ToString();
                
            }
            return numberString;
        }

        public static bool HasDifferentNumbers(int number)
        {
            List<int> digitList = NumberToList(number);
            List<int> distinctList = digitList.Distinct().ToList();
            if (distinctList.Count() >= 2)
                return true;
            return false;
        }

        public static void Kaprekar(int number)
        {
            // Method that shows how many iterations it takes to get from the given number to 6174. Solves challenge in Bonus 2.
            if (HasDifferentNumbers(number))
            {
                int descendingDigits = Convert.ToInt32(SortDigitList(SortDirection.Descending, number));
                int ascendingDigits = Convert.ToInt32(SortDigitList(SortDirection.Ascending, number));
                int count = 0;
                int result = 0;
                while (result != 6174)
                {
                    result = descendingDigits - ascendingDigits;
                    descendingDigits = Convert.ToInt32(SortDigitList(SortDirection.Descending, result));
                    ascendingDigits = Convert.ToInt32(SortDigitList(SortDirection.Ascending, result));
                    if (count == 0 && result == 6174)
                        break;
                    count++;
                }
                Console.WriteLine("(" + number + ")" + count);
                
            }
        }
    }
}
