namespace DotDetector
{
    public class Circle
    {
        double x;
        double y;
        double radius;

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="x">Координата "x" центра окружности</param>
        /// <param name="y">Координата "y" центра окружности</param>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        
        /// <summary>
        /// Метод определяет, лежит ли заданная точка в окружности
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <returns>Лежит ли точка в окружности?</returns>
        public bool IsPointBelong(double x, double y)
        {
            return Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2) <= Math.Pow(radius, 2);
        }
    }
}
