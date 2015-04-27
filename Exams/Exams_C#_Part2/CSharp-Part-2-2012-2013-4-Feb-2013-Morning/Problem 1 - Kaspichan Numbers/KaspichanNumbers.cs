using System;

class Program
{
    static void Main()
    {
        //array of 256 elements 
        ulong numBase = 256;
        string[] arr = new string[numBase];


        //pulnim chislata 
        for (ulong i = 0; i < numBase; i++)
        {
            if (i < 26)
            {
                arr[i] = string.Format("{0}", ((char)(i + 'A')));
            }
            else
            {
                arr[i] = string.Format("{0}{1}", ((char)(i / 26 - 1 + 'a')),(char)(i%26 + 'A'));
            }
        }
        //read input 
        ulong input = ulong.Parse(Console.ReadLine());

        //calculations 
        string result = string.Empty;

        if (input == 0)
        {
            result = 'A'.ToString();
        }
        while (input > 0)
        {
            ulong num = input % numBase;
            result = arr[num] + result;
            input /= numBase;
        }
        

        //output
        Console.WriteLine(result);

    }
}

