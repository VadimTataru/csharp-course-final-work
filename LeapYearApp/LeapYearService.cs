namespace LeapYearApp
{
    public class LeapYearService
    {
        /// <summary>
        /// Метод определяет, является ли год високосным.
        /// <returns>Год високосный? - true, иначе - false</returns>
        /// </summary>
        public static bool IsLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else
                return false;
        }
    }
}
