//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;
 
class Program
{
    static void Main(string[] args)
    {
        int array_size = 10;
        int [] array =  new int [10] {100, 50, 20, 40, 10, 60, 80, 70, 90, 30};
 
 
        Console.WriteLine("The array before Selection Sort is: ");
        for (int i = 0; i < array_size; i++)
        {
            Console.WriteLine("array[" +i +"] = " +array[i]);
        }
 
        // Now we will use selection sort
        int tmp, min_key;
 
        for (int j = 0; j < array_size - 1; j++)
        {
            min_key = j;
 
            for (int k = j + 1; k < array_size; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }
 
            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
 
        Console.WriteLine("The array after Selection Sort is: ");
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("array[" +i +"] = " +array[i]);
        }
    }
}
