//Task 1. Class Size in C#
//Refactor the following code to use proper variable naming and simplified expressions:

namespace ClassSize
{
    using System;

    internal class Rectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Rectangle RotatedBoxSizes(double width, double height, double antiClockwiseRotationDegree)
        {
            var bottomFirstPart = Math.Abs(Math.Cos(antiClockwiseRotationDegree)) * width;
            var bottomSecondPart = Math.Abs(Math.Sin(antiClockwiseRotationDegree)) * height;

            var sideFirstPart =  Math.Abs(Math.Sin(antiClockwiseRotationDegree)) * width;
            var sideSecondPart = Math.Abs(Math.Cos(antiClockwiseRotationDegree)) * height;

            var newWidth = bottomFirstPart + bottomSecondPart;
            var newHeight = sideFirstPart + sideSecondPart;

            var newRectangle = new Rectangle(newWidth, newHeight);
            return newRectangle;
        }

        public void PrintStatistics(double[] array)
        {
            var count = array.Length;
            double maximalNumber = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                var currentNumber = array[i];
                if (currentNumber > maximalNumber)
                {
                    maximalNumber = currentNumber;
                }
            }

            //PrintMax(maximalNumber);

            var minimalNumber = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                var currentNumber = array[i];
                if (currentNumber < minimalNumber)
                {
                    minimalNumber = currentNumber;
                }
            }

            //PrintMin(minimalNumber);

            double averageValue = 0;

            for (int i = 0; i < count; i++)
            {
                var currentNumber = array[i];
                averageValue += currentNumber;
            }

            //PrintAvg(averageValue / count);
        }

    }
}