using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3SD43_Task
{
    internal class HiringDate
    {

        int day;
        int month;
        int year;

        public HiringDate(int _day,int _month,int _year)
        {
            day= _day;
            month= _month;
            year= _year;   
        }

        public int Day { get { return day; } set {day=value ; } }
        public int Month { get { return month; } set { month=value ; } }
        public int Year { get { return year;} set { year=value ; } }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
