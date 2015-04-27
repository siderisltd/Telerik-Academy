//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of 
//elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

//Example:
//input 	                                      result
//6, 1, 4, 3, 0, 3, 6, 4, 5 	                  1, 3, 3, 4, 5

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> remainingArr = new List<int>();
        remainingArr.Add(-1);
        int[] arr = new int[]
        {
            6, 1, 4, 3, 0, 3, 6, 4, 5
        };

        int firstDigit = new int();
        int secondDigit = new int();

        bool isReady = false;

        int startIndex = 0;
        int secondIndex = 1;
        int endIndex = arr.Length - 1 ;

        int listCount = 0;


       // while (isReady == false)
       // {
            for (int i = startIndex, j = secondIndex; i < endIndex; i += 2,j += 2)
            {
                firstDigit = arr[i];
                secondDigit = arr[j];
                if (firstDigit >= secondDigit && secondDigit >= remainingArr[listCount])
                {

                        remainingArr.Add(secondDigit);
                        listCount++;                    
                }
                else if (firstDigit <= secondDigit && firstDigit <= remainingArr[listCount])
                {
                    remainingArr.Add(secondDigit);
                    listCount++;
                }
                if (i == endIndex - 2)
                {
                    firstDigit = arr[arr.Length-1];
                    secondDigit = arr[arr.Length-2];
                    if (secondDigit <= firstDigit)
                    {
                        remainingArr.Add(firstDigit);
                    }
                }

            }
      //  }
            for (int i = 1; i < remainingArr.Count; i++)
            {
                Console.Write(remainingArr[i] + " ");
            }

    }
}
