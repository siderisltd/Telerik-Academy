using System;

class CoordinateSystem
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());
        int result = 0;
        if (X == 0 && Y == 0)
        {
            result = 0;
        }
        else if (X > 0 && Y > 0)
        {
            result = 1;
        }
        else if (X < 0 && Y > 0)
        {
            result = 2;
        }
        else if (X < 0 && Y < 0)
        {
            result = 3;
        }
        else if (X > 0 && Y < 0)
        {
            result = 4;
        }
        else if (X == 0)
        {
            result = 5;
        }
        else
        {
            result = 6;
        }
        Console.WriteLine(result);
    }
}