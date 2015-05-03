namespace Coordinates
{
    public struct Point3D
    {
        private static readonly int ZeroIndex = 5;

        private static Point3D zeroPoint;

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D ZeroPoint
        {
            get
            {
                zeroPoint.X = ZeroIndex;
                zeroPoint.Y = ZeroIndex;
                zeroPoint.Z = ZeroIndex;
                return zeroPoint;
            }
        }
        
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public new void ToString()
        {
            System.Console.WriteLine("X = {0}",X);
            System.Console.WriteLine("Y = {0}",Y);
            System.Console.WriteLine("Z = {0}",Z);
        }
    }
}
