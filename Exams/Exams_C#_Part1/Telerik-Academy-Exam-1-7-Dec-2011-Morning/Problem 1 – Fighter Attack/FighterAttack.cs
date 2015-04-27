using System;

class Program
{
    static void Main()
    {
        int PX1 = int.Parse(Console.ReadLine());
        int PY1 = int.Parse(Console.ReadLine());
        int PX2 = int.Parse(Console.ReadLine());
        int PY2 = int.Parse(Console.ReadLine());

        if (PX1 > PX2)
        {
            int temp = PX1;
            PX1 = PX2;
            PX2 = temp;
        }
        if (PY1 > PY2)
        {
            int temp = PY1;
            PY1 = PY2;
            PY2 = temp;
        }

        int FX = int.Parse(Console.ReadLine());
        int FY = int.Parse(Console.ReadLine());

        int D = int.Parse(Console.ReadLine());

        int damage = 0;

        FX += D;

        if (PX1 <= FX && FX <= PX2)
        {
            if (PY1 <= FY && FY <= PY2)
            {
                damage += 100;
            }
            if (PY1 - 1<= FY && FY - 1 <= PY2)
            {
                damage += 50;
            }
            if (PY1 + 1 <= FY && FY + 1 <= PY2)
            {
                damage += 50;
            }
        }
        if (PX1 <= FX + 1 && FX + 1 <= PX2)
        {
            if (PY1 <= FY && FY <= PY2)
            {
                damage += 75;
            }
        }
        Console.WriteLine("{0}",damage + "%");
    }
}