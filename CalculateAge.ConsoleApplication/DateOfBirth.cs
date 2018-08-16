using System;

namespace CalculateAge.ConsoleApplication
{
    class DateOfBirth
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public DateOfBirth()
        {
            Day = 1;
            Month = 1;
            Year = 1900;
        }

        public bool IsValidDate(string date)
        {
            DateTime temp;
            if (DateTime.TryParse(date, out temp))
            {
                this.Day = temp.Day;
                this.Month = temp.Month;
                this.Year = temp.Year;
                return true;
            }
            else
                return false;
        }

        public void ShowAge()
        {

        }
    }
}
