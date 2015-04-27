namespace Coordinates
{
    public static class DistanceBetweenPoints
    {
        public static void DistanceBetweenPoint(Point3D first, Point3D second)
        {
            decimal distance = new decimal();
            if (first.X >= second.X)
            {
                distance += first.X - second.X;
            }
            else if (first.X < second.X)
            {
                distance += second.X - first.X;
            }

            if (first.Y >= second.Y)
            {
                distance += first.Y - second.Y;
            }
            else if (first.Y < second.Y)
            {
                distance += second.Y - first.Y;
            }

            if (first.Z >= second.Z)
            {
                distance += first.Z - second.Z;
            }
            else if (first.Z < second.Z)
            {
                distance += second.Z - first.Z;
            }

            System.Console.WriteLine("Distance is : {0} SqP", distance);
        }
    }
}
