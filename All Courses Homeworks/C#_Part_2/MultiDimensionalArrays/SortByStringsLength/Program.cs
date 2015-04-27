//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = { "hihi","haha","hohoho","hahahhaa","hh","h" };

        var sorted = array.OrderBy(str => str.Length);

        foreach (var str in sorted)
        {
            Console.WriteLine(str);
        }
    }
}

