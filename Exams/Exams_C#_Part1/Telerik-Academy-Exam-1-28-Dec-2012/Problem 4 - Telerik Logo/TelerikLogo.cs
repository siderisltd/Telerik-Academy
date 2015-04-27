using System;

class telerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = (x / 2) + 1;
        int width = (2 * z + 2 * y) - 3;
        int firstOuterDots = x / 2;
        int innerDots = (width - x) - 1;
            Console.Write(new string('.', firstOuterDots));
        Console.Write('*');
        Console.Write(new string('.', innerDots));
        Console.Write('*');
        Console.WriteLine(new string('.', firstOuterDots));
        innerDots -= 2;
        int firstHornDots = x / 2 - 1;
        int dotsAfterHorn = 0;
        for (int i = 1; i < x - 1; i++)
        {
            if (i <= x/2)
            {
                Console.Write(new string('.', firstHornDots));
                Console.Write('*');
                Console.Write(new string('.', dotsAfterHorn));
                
            }
            else
            {
                Console.Write(new string('.', firstOuterDots));
            }
            Console.Write(new string ('.',i));
            Console.Write('*');
            Console.Write(new string ('.',innerDots));
            Console.Write('*');
            Console.Write(new string('.', i));
            if (i <= x / 2)
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write('*');
                Console.Write(new string('.', firstHornDots));
                firstHornDots--;
                dotsAfterHorn++;

            }
            else
            {
                Console.Write(new string('.', firstOuterDots));
            }
            innerDots -= 2;
            Console.WriteLine();
        }
        Console.Write(new string('.',width/2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));
        int leftRightDots = x - 2;
        innerDots = 1;
        for (int a = 0; a < x-1; a++)
        {
            Console.Write(new string('.', firstOuterDots));
            Console.Write(new string('.', leftRightDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('.', firstOuterDots));
            leftRightDots--;
            innerDots += 2;
            Console.WriteLine();
        }
        leftRightDots = x / 2 +1;
        innerDots -= 4;
        for (int a = 0; a < x - 2; a++)
        {
            Console.Write(new string('.', leftRightDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', leftRightDots));
            leftRightDots++;
            innerDots -= 2 ;
            if (innerDots <= 0 )
            {
                innerDots = 0;
            }
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));

    }
}