using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EvenDifferences
{
    class Program
    {
        static void Main()
        {
            //input
            //string[] inp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            BigInteger[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            //ulong[] iii = new ulong[inp.Length];
            //for (int i = 0; i < inp.Length; i++)
            //{
            //    iii[i] = ulong.Parse(inp[i]);
            //}
            BigInteger sum = 0;
            BigInteger currentAD = 0;
            List<BigInteger> test = new List<BigInteger>();

            //tova e proverkata za sumata, koqto trqbwa da se izkara
            //if (currentAD % 2 == 0)
            //{
            //    sum += currentAD;
            //}

            //logic
            int previous = 0;
            for (int index = 1; index < input.Length; index++)
            {
                previous = index - 1;
                if (input[index] > input[previous])
                {
                    currentAD = input[index] - input[previous];
                }
                if (input[index] < input[previous])
                {
                    currentAD = input[previous] - input[index];
                }
                if (input[index] == input[previous])
                {
                    // shte go mislim - ili nula ili chisloto
                    currentAD = 0;
                }
                if (currentAD % 2 == 0)
                {
                    index++;
                }
                if (currentAD % 2 != 0)
                {

                }

                test.Add(currentAD);
            }


            //output
            foreach (var item in test)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
