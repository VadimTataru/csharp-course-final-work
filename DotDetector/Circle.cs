namespace DotDetector
{
    internal class Circle
    {
        int x;
        int y;
        int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public Circle((int, int) point, int radius): this(point.Item1, point.Item2, radius)
        {            
        }

        public bool IsPointBelong(int x, int y)
        {
            return (int)Math.Pow(this.x - x, 2) + (int)Math.Pow(this.y - y, 2) <= (int)Math.Pow(this.radius, 2);
        }

        public bool IsPointBelong((int, int) point)
        {
            return IsPointBelong(point.Item1, point.Item2);
        }
    }
}
