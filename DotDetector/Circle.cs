namespace DotDetector
{
    public class Circle
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

        public bool IsPointBelong(double x, double y)
        {
            return Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2) <= Math.Pow(radius, 2);
        }
    }
}
