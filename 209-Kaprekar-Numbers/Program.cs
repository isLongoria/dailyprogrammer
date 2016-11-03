using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_10_31__Kaprekar_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeStart = 2;
            int rangeEnd = 100;
            KaprekarNumbers(rangeStart, rangeEnd);

            Console.WriteLine();

            rangeStart = 101;
            rangeEnd = 9000;
            KaprekarNumbers(rangeStart, rangeEnd);

            Console.ReadKey();
        }

        public static void KaprekarNumbers(int startNum, int endNum)
        {
            List<int> KaprekarNums = new List<int>();
            for(int i = startNum; i <= endNum; i++)
            {
                double squaredNumber = Math.Pow(i, 2);
                int squaredNumberLenght = squaredNumber.ToString().Length;
                if(squaredNumberLenght > 1)
                {
                    for(int j = 1; j < squaredNumberLenght; j++)
                    {
                        string firstSubstring = squaredNumber.ToString().Substring(0, j);
                        string secondSubstring = squaredNumber.ToString().Substring(j, squaredNumberLenght - j);

                        if(Convert.ToInt32(secondSubstring) != 0)
                        {
                            int result = Convert.ToInt32(firstSubstring) + Convert.ToInt32(secondSubstring);
                            if (result == i)
                                KaprekarNums.Add(i);
                        }                        
                    }
                    
                }
                
            }
            KaprekarNums.ForEach(Console.Write);
        }
    }
}
