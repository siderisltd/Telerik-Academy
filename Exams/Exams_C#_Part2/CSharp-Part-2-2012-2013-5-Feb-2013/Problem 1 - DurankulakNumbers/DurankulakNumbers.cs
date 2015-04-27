using System;

namespace DurankulakNumbers
{
    class Program
    {
        static void Main()
        {
            ulong baseNum = 168;
            //input
            string input = Console.ReadLine(); // fLfLfLfLfLfLfLfL

            //logic
            ulong num = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                string currentNumber = string.Empty;

                if (Char.IsLower(letter))
                {
                    currentNumber = String.Format("{0}{1}", input[i],input[i+1]);
                    i++;
                }
                else
                {
                    currentNumber = String.Format("{0}", letter);
                }
                //find current number
                num *= baseNum;
                if (currentNumber.Length == 1)
                {
                    num += ((ulong)currentNumber[0] - 'A');
                }
                else // if length == 2
                {
                    num += (ulong)(currentNumber[0] - 'a' + 1) * 26;
                     num += ((ulong)currentNumber[1] - 'A');
                }
            }
            //output
            Console.WriteLine(num);
        }
    }
}
