using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long r = 0;
        long result = 0;

        switch (b)
        {
            case 2:
                result = a % c;
                break;
            case 4:
                result = a + c;
                break;
            case 8:
                result = a * c;
                break;
            default:
                break;
        }
        r = result;
        if (result % 4 == 0)
        {
            result /= 4;
        }
        else if (result % 4 != 0)
        {
            result %= 4;
        }
            Console.WriteLine(result);
            Console.WriteLine(r);
    }
}
