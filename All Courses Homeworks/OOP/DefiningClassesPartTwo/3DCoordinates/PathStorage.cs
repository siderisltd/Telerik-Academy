namespace Coordinates
{
    using System.IO;
    using System;
    using System.Linq;
    //6 tochki trqbva da izmukna
    public static class PathStorage
    {
        private static string fileName = "SavedCoordinates.txt";
        private static string filePath = @"../../Files/";
        private static StreamReader coords = new StreamReader(@"../../Files/Coordinates.txt");
        private static StreamWriter savedCoords;
        private static Path paths = new Path();
        private static Point3D currentPoint = new Point3D();

        public static void LoadPaths()
        {
            string[] coordinates;
            using (coords)
            {
                 coordinates = coords.ReadToEnd().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            for (int i = 0; i < coordinates.Length; i++)
            {
                string currentPair = coordinates[i];
                string[] currentValuesOfCoordinates = currentPair.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < currentValuesOfCoordinates.Length; j++)
                {
                    if (j == 0)
                    {
                        currentPoint.X = int.Parse(currentValuesOfCoordinates[j]);
                    }
                    else if (j == 1)
                    {
                        currentPoint.Y = int.Parse(currentValuesOfCoordinates[j]);
                    }
                    else if (j == 2)
                    {
                        currentPoint.Z = int.Parse(currentValuesOfCoordinates[j]);
                    }
                }
                paths.SequenceOfPoints.Add(currentPoint);
                currentPoint = new Point3D();
            }
            SavePaths(paths);
        }

        public static void SavePaths(Path paths)
        {
            savedCoords = new StreamWriter(filePath + fileName);
            using (savedCoords)
            {
                foreach (var path in paths.SequenceOfPoints)
                {
                    savedCoords.WriteLine(String.Format("X: {0} Y: {1} Z: {2}", path.X, path.Y, path.Z));
                }
            }
        }

        public static void SavePaths(Path paths, string fileName)
        {
            savedCoords = new StreamWriter(filePath + fileName);
            using (savedCoords)
            {
                foreach (var path in paths.SequenceOfPoints)
                {
                    savedCoords.WriteLine(String.Format("X: {0} Y: {1} Z: {2}", path.X, path.Y, path.Z));
                }
            }
        }
    }
}
