namespace RefactoringComplexLoop
{
    using System;
    using System.Collections;

    public class FindValue
    {
        static void Main()
        {
            double[] array = new double[] { 1,2,3,3,4,4,5,6,7 };
            bool isFound = FindValueInArray(array, 3);
            // More code here
            if (isFound == true)
            {
                Console.WriteLine("Value Found");
            }
        }

        private static bool FindValueInArray(IEnumerable collection, double expectedValue)
        {
            var isFound = false;

            foreach (var item in collection)
            {
                var i = 0;
                Console.WriteLine(item);
                if (i % 10 == 0)
                {
                    if (item.ToString() == expectedValue.ToString())
                    {
                        isFound = true;
                        break;
                    }
                }
                i++;
            }

            return isFound;
        }
    }
}
