namespace DotDetector
{
    internal class Circle
    {
        double x;
        double y;
        double radius;

        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public Circle((double, double) point, double radius): this(point.Item1, point.Item2, radius)
        {            
        }

        public bool IsPointBelong(double x, double y)
        {
            return Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2) <= Math.Pow(radius, 2);
        }

        public bool IsPointBelong((double, double) point)
        {
            return IsPointBelong(point.Item1, point.Item2);
        }
    }
}
