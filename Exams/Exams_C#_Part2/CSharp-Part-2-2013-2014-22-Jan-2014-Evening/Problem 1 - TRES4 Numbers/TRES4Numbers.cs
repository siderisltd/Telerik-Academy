using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES4Numbers
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string result = ConvertFromDec(number, 9);
            StringBuilder newRes = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case '0': newRes.Append("LON+"); break;
                    case '1': newRes.Append("VK-"); break;
                    case '2': newRes.Append("*ACAD"); break;
                    case '3': newRes.Append("^MIM"); break;
                    case '4': newRes.Append("ERIK|"); break;
                    case '5': newRes.Append("SEY&"); break;
                    case '6': newRes.Append("EMY>>"); break;
                    case '7': newRes.Append("/TEL"); break;
                    case '8': newRes.Append("<<DON"); break;
                }
            }
            Console.WriteLine(newRes.ToString());
        }
        
        static string ConvertFromDec(ulong number, ulong baseTo)
        {
            List<ulong> result = new List<ulong>();
            ulong res = 0;
                while (number > 0)
                {
                    result.Add(number % baseTo);
                    number = number / baseTo;
                }
                result.Reverse();
                StringBuilder re = new StringBuilder();
                foreach (var item in result)
                {
                    re.Append(item);
                }
                return re.ToString();
        }
    }
}