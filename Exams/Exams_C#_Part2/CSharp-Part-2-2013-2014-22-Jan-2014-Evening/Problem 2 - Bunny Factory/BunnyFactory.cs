using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //input = input.Remove(input.Length - 3, input.Length);

            string str = input;
            int a = 0;
            while (input != "END")
            {
                if (a == 0)
                {
                    input = string.Empty;
                }
                if (str == "END")
                {
                    break;
                }
                input += " " + str + " ";
                str = Console.ReadLine();
                a++;
                
            }
            ulong[] cagesAndBunnys = input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(ulong.Parse).ToArray();
            //concatenating
            StringBuilder concatResult = new StringBuilder();
            int index = 0;
            while (true)
            {
                ulong sum = cagesAndBunnys[index]; 
                for (int i = 0; i < index; i++)
                {
                    sum += cagesAndBunnys[i];
                }
                BigInteger nextSum = 0;// = cagesAndBunnys[1] + cagesAndBunnys[2] + cagesAndBunnys[3];
                BigInteger nextProduct = 1;// = cagesAndBunnys[1] * cagesAndBunnys[2] * cagesAndBunnys[3];
                if ((ulong)cagesAndBunnys.Length < sum)
                {
                    Console.WriteLine(string.Join(" ",cagesAndBunnys).Trim());
                    break;
                }
                ulong count = 0;
                for (ulong i = (ulong)index + 1; i <= (ulong)sum + (ulong)index; i++)
                {
                    nextSum += cagesAndBunnys[i];
                    nextProduct *= cagesAndBunnys[i];
                    count++;
                }

                concatResult.Append(nextSum.ToString());
                concatResult.Append(nextProduct.ToString());

                    for (ulong i = count; i < (ulong)cagesAndBunnys.Length - 1; i++)
                    {
                        if (i + 1 + (ulong)index < (ulong)cagesAndBunnys.Length)
                        {
                            concatResult.Append(cagesAndBunnys[i + 1 + (ulong)index]);
                        }
                    }


                for (int i = 0; i < concatResult.Length; i++)
                {
                    if (concatResult[i].ToString() == "0" | concatResult[i].ToString() == "1")
                    {
                        concatResult.Remove(i, 1);
                        i--;
                    }
                }
                int ind = 0;
                cagesAndBunnys = new ulong[concatResult.Length];
                foreach (var digit in concatResult.ToString())
                {
                    if (digit == ' ')
                    {
                       
                    }
                    else
                    {
                        cagesAndBunnys[ind] = ulong.Parse(digit.ToString());
                        
                    }
                    ind++;
                }
                concatResult = concatResult.Remove(0, concatResult.Length);
                //cagesAndBunnys = concatResult.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(ulong.Parse).ToArray();
                index++;
            }



            //nextcages


            //biginteger

        }
    }
}