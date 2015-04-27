namespace Coordinates
{
    using System;
    using System.Linq;
    [VersionAttribute("A.S", "version 0.12")]
    [VersionAttribute("A.S", "version 1.01")]
    public class MainClass
    {
        private static void Main()
        {
            GenericMatrix<int> firstMatrix = new GenericMatrix<int>(3, 2);
            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 4;
            firstMatrix[2, 0] = 5;
            firstMatrix[2, 1] = 6;
            GenericMatrix<int> secondMatrix = new GenericMatrix<int>(3, 2);
            secondMatrix[0, 0] = 1;
            secondMatrix[0, 1] = 2;
            secondMatrix[1, 0] = 0;
            secondMatrix[1, 1] = 4;
            secondMatrix[2, 0] = 5;
            secondMatrix[2, 1] = 6;
                           //Checking the operators for adding, substracting and multiplying
            GenericMatrix<int> resultFromAdding = firstMatrix + secondMatrix;
            GenericMatrix<int> resultFromSubstracting = firstMatrix - secondMatrix;
            GenericMatrix<int> resultFromMultiplication = firstMatrix * secondMatrix;

                               //Showing the attribute at runtime
            Type type = typeof(MainClass);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (object attribute in attributes)
            {
                VersionAttribute version = (VersionAttribute)attribute;
                Console.WriteLine(version.Version);
            }
                
                                  //Checking the true operator
            if (secondMatrix)
            {
                Console.WriteLine("SecondMatrix Contains Zero");
            }
            else
            {
                Console.WriteLine("SecondMatrix Not Contains Zero");
            }


            //Console.WriteLine(matrix[2,1]);
            //matrix[1, 1] = 5;
            //matrix[0, 1] = 3;
            //matrix[1, 1] = 4;


            Point3D newpoint = new Point3D();
            newpoint.X = 5;
            newpoint.Y = 8;
            newpoint.Z = 1;
            //The overrided ToString() prints us the points on the console

            //newpoint.ToString();

            //This is the static point with coordinates 5,5,5 to test it because 0,0,0 is by default and it will
            //aways work

            //Point3D.ZeroPoint.ToString();

            Point3D ad = new Point3D(4, 5, 6);

            //This Class creates List of paths
            Path newPath = new Path();
            newPath.SequenceOfPoints.Add(newpoint);
            newPath.SequenceOfPoints.Add(Point3D.ZeroPoint);
            newPath.SequenceOfPoints.Add(ad);

                //This class Saves the currentPath in text file, you can type the name and it will appear in the
                    //Files folder "../../Files" in the project

            // PathStorage.SavePaths(newPath, "mitko.doc");

                    // This will load a coordinate file from the same directory - Files and will split and initialize
                  // them and will save them in SavedPaths.txt automaticly

            //PathStorage.LoadPaths();

                         //This is Class that calculate the difference between two points

            //DistanceBetweenPoints.DistanceBetweenPoint(newpoint, Point3D.ZeroPoint);


            GenericList<int> test = new GenericList<int>(5);
            test.Add(5);
            test.Add(34);
            test.Remove(0);
            test.Insert(2, 1);
            test.Add(4);
            test.Insert(3, 1);

            test.Insert(4, 1);

            test.Add(8);
            //Auto grow functionality is turned on from now on
            test.Add(9);
            test.Add(10);
            //Gets the minValue in the GenericList
            test.Min();
            test.Max();
            //this is for testing the object states
            //Console.WriteLine(test[0] + " " + test[1] + " " + test[2] + " " + test[3]);
            //testing the ToString()
            //Console.WriteLine(test[0].ToString());
            test.Contains(2);
            test.Contains(100);
        }
    }
}
