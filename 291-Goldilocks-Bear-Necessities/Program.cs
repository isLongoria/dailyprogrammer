using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _291_Goldilock_s_Bear_Necessities
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] input = new int[,]
            {
                {100, 120 },
                {297, 90 },
                {66, 110 },
                {257, 113 },
                {276, 191 },
                {280, 129 },
                {219, 163 },
                {254, 193 },
                {86, 153 },
                {206, 147 },
                {71, 137 },
                {104, 40 },
                {238, 127 },
                {52, 146 },
                {129, 197 },
                {144, 59 },
                {157, 124 },
                {210, 59 },
                {11, 54 },
                {268, 119 },
                {261, 121 },
                {12, 189 },
                {186, 108 },
                {174, 21 },
                {77, 18 },
                {54, 90 },
                {174, 52 },
                {16, 129 },
                {59, 181 },
                {290, 123 },
                {248, 132 }
            };

            int weight = input[0, 0];
            int maxTemp = input[0, 1];
            List<int> validWeights = new List<int>();
            List<int> validTemps = new List<int>();

            for (int i = 1; i < input.Length / 2; i++)
            {
                if (input[i, 0] > weight)
                    validWeights.Add(i);
            }

            if (validWeights.Count() > 0)
            {
                for (int i = 0; i < validWeights.Count(); i++)
                {
                    if (input[validWeights[i], 1] < maxTemp)
                        validTemps.Add(validWeights[i]);
                }
            }

            if (validTemps.Count() > 0)
                foreach (int i in validTemps)
                {
                    Console.WriteLine(i);
                }
            Console.ReadKey();
        }
    }
}
