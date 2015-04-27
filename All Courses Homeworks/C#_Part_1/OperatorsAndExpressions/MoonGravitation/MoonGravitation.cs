//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;

class Carpets
{
    static void Main()
    {
        float earthWeight = float.Parse(Console.ReadLine());
        float moonWeight = earthWeight * 0.17f;
        Console.WriteLine(moonWeight.ToString("F3")); // for correct imput
    }
}

