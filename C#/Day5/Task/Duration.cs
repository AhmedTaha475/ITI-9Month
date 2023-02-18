using D5SD43_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
    internal class Duration
    {
        public int Seconds { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public int TotalTimeInSec { get; set; }
        public Duration(int _hours, int _min, int _sec)
        {
            Seconds = _sec;
            Hours = _hours;
            Minutes = _min;
            TotalTimeInSec = Hours * 60 * 60 + Minutes * 60 + Seconds;
        }
        public Duration()
        {
            Seconds = 0;
            Hours = 0;
            Minutes = 0;
            TotalTimeInSec = 0;
        }

        public Duration(int timeInSec)
        {
            decimal totalMin = Math.Floor((decimal)timeInSec / 60);
            Seconds = timeInSec % 60;
            Minutes = (int)totalMin % 60;
            Hours = (int)Math.Floor(totalMin / 60);
            TotalTimeInSec = timeInSec;
        }

        
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration((left?.TotalTimeInSec ?? 0) + (right?.TotalTimeInSec ?? 0));
        }
        public static Duration operator +(Duration left, int right)
        {
            return new Duration((left?.TotalTimeInSec ?? 0) + right);
        }
        public static Duration operator +(int left, Duration right)
        {
            return new Duration(left + (right?.TotalTimeInSec ?? 0));
        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration((left?.TotalTimeInSec ?? 0) - (right?.TotalTimeInSec ?? 0));
        }
        public static Duration operator -( Duration right)
        {
            return new Duration( - (right?.TotalTimeInSec ?? 0));
        }

        public static Duration operator ++(Duration obj)
        {
            return new Duration() { Hours = obj?.Hours ?? 0, Minutes = (obj?.Minutes ?? 0) + 1,
                Seconds = obj?.Seconds ?? 0, TotalTimeInSec = (obj?.TotalTimeInSec ?? 0) + 60 };

        }

        public static Duration operator --(Duration obj)
        {
            return new Duration() { Hours = obj?.Hours ?? 0, Minutes = (obj?.Minutes ?? 0) - 1, Seconds = obj?.Seconds ?? 0, TotalTimeInSec = (obj?.TotalTimeInSec ?? 0) - 60 };
        }

        public static bool operator >(Duration left, Duration right)
        {
            return left.TotalTimeInSec > right.TotalTimeInSec;
        }
        //public static bool operator == (Duration left, Duration right) { return left.Equals(right);}
        public static bool operator ==(Duration left, Duration right) { return left.TotalTimeInSec==right.TotalTimeInSec; }
        //public static bool operator !=(Duration left,Duration right) { return !left.Equals(right); }
        public static bool operator !=(Duration left,Duration right) { return (left.TotalTimeInSec!=right.TotalTimeInSec); }

        public static bool operator <(Duration left, Duration right)
        {
            return left.TotalTimeInSec < right.TotalTimeInSec;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return left.TotalTimeInSec >= right.TotalTimeInSec;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            return left.TotalTimeInSec <= right.TotalTimeInSec;
        }

        public static explicit operator DateTime(Duration d1)
        {
            int counter = 0;
            do
            {
                d1.Minutes++;
                d1.Seconds = d1.Seconds - 60;
            } while (d1.Seconds>60);

            do
            {
                d1.Hours++;
                d1.Minutes=d1.Minutes - 60;

            } while (d1.Minutes>60);

            do
            {
                counter++;
                d1.Hours=d1.Hours - 24;
            } while (d1.Hours>24);


            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+counter, d1.Hours, d1.Minutes, d1.Seconds);
        }
       
        public static bool operator true(Duration d)
        {
            return d.TotalTimeInSec > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.TotalTimeInSec < 0;
        }
        public override string ToString()
        {
            return $"Hours:{Hours},Minutes:{Minutes},Seconds:{Seconds}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            Duration r1= (Duration)obj;
            return (this?.TotalTimeInSec??0)==(r1?.TotalTimeInSec??0);
        }
    }
}



//From mahmoud sherif to Everyone 01:58 PM
//if (left.hours % 24 >= 0) { left.hours = 0; day += 1; }
//if (day >= 30) { day = 0; month += 1; }
//if (month >= 12) { month = 0; year += 1; }


//public static explicit operator DateTime(Duration left)
//{
//    DateTime localDate = DateTime.Now;
//    int year = localDate.Year;
//    int month = localDate.Month;
//    int day = localDate.Day;
//    while (left.hours >= 24) { left.hours -= 24; day += 1; }
//    while (day >= 30) { day -= 30; month += 1; }
//    while (month >= 12) { month -= 12; year += 1; }
//    {
//        return new DateTime(year, month, day, left.hours, left.minutes, left.seconds);
//    }
//}
