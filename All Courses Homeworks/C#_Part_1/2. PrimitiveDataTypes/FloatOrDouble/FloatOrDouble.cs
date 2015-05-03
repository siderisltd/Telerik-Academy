//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of 
//type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.


using System;


class FloatOrDouble
{
    static void Main()
    {
        float firstFloatNumber = 12.345f; 
        float secondFloatNumber = 3456.091f;
        double firstDoubleNumber = 8923.1234857;
        double secondDoubleNumber = 34.567839023;
        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}",firstFloatNumber,secondFloatNumber,firstDoubleNumber,secondDoubleNumber);
    }
}

