namespace LeapYear
{
    public class Year
    {
        private readonly int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool IsLeap()
        {
            return year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0);
        }
    }
}