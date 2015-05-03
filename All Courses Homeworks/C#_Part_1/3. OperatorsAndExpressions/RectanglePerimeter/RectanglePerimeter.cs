//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class RectanglePerimeter
{
    static void Main()
    {
        Console.Write("Enter Width : ");
        float widht = float.Parse(Console.ReadLine());

        Console.Write("Enter Height : ");
        float height = float.Parse(Console.ReadLine());

        float perimeter = 2 * (widht + height);
        float area = widht * height;

        Console.WriteLine("Perimeter : {0}\r\nArea : {1}",perimeter,area);
    }
}
