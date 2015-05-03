//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
//floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other 
//than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine(nearlyEqual(5.3, 6.1));
        
    }

    public static Boolean nearlyEqual(double absA, double absB)
    {
        double epsilon = 0.000001;
        absA = Math.Abs(absA);
        absB = Math.Abs(absB);
        double diff = Math.Abs(absA - absB);

        if (absA == absB)
        { // shortcut, handles infinities
            return true;      
        }
        else if (diff<epsilon)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}