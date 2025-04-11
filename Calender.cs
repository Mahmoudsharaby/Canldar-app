using System;
using System.Globalization;

namespace WindowsFormsApp1
{
    internal class calender
    {
        public class Calendar

        {
            public int Year = DateTime.Now.Year;
            public int Month = DateTime.Now.Month;
            public int Day = DateTime.Now.Day;
            public DateTime Date = DateTime.Now;


            public int Y = DateTime.Now.Year;
            public int M = DateTime.Now.Year;
            public int D { get; set; }
            public DateTime d { get; set; }


            public void Pre(ref int month, ref int year)
            {
                month -= 1;
                if (month < 1)
                {
                    month = 12;
                    year -= 1;
                }

            }
            public void Next(ref int month, ref int year)
            {
                month += 1;
                if (month > 12)
                {
                    month = 1;
                    year += 1;
                }

            }


            public int First_Day(int year, int month)
            {
                DateTime first = new DateTime(year, month, 1);
                return (int)first.DayOfWeek;
                //return first.DayOfWeek.ToString();
                //Warning!!! sunday is 0 
            }

            public void convert(ref DateTime date)
            {
                int year = date.Year;
                int month = date.Month;
                int day = date.Day;
            }
            public static DateTime convert(int Year, int Month, int Day)
            {
                var date = new DateTime(Year, Month, Day);
                return date;
            }

            public int Month_Length(int year, int month)
            {
                var calendar = new GregorianCalendar();
                var days = calendar.GetDaysInMonth(year, month);
                return days;
            }
            public string Month_Name(int month)
            {
                DateTime Name = new DateTime(2024, month, 22);
                return Name.ToString("MMMM");
            }
        }
    }
}