using System;
using System.Linq;
using System.Collections.Generic;

namespace CalculationProblem
{
    class Program
    {
        static void Main()
        {
            //input
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            SortedDictionary<char,int> lettersArr = new SortedDictionary<char,int>();

            string stringResult = string.Empty;
            int intResult = new int();


            for (int i = 0; i < 23; i++)
            {
                lettersArr.Add((char)(i + 97), i);
            }
            
            int power = new int();
            int numeralSystem = 23;

            foreach (var word in input)
            {
                power = word.Length - 1;
                for (int i = 0; i < word.Length; i++)
                {
                    foreach (var letter in lettersArr)
                    {
                        if (letter.Key == word[i])
                        {
                            intResult += letter.Value * (int)(Math.Pow(numeralSystem, power));
                            power--;
                        }
                    }
                }
            }
            List<int> res = new List<int>();
            res = ConvertFromDec(intResult, 23);
            foreach (var digit in res)
            {
                foreach (var letter in lettersArr)
                {
                    if (letter.Value == digit)
                    {
                        stringResult += letter.Key;
                    }
                }

            }

            Console.WriteLine("{0} = {1}", stringResult, intResult);
        }

        static List<int> ConvertFromDec(int number, int baseTo)
        {
            List<int> result = new List<int>();

            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            return result;
        }
    }
}
