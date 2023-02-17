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

        public int getDay()
        {
            return day;
        }
        public void setDay(int _day)
        {
            day = _day;
        }
        public int getMonth()
        {
            return month;

        }
        public void setMonth(int _month)
        {
            month = _month;
        }
        public int getYear() { 
            return year;
        }
        public void setYear(int _year) {
            year= _year;
        }

    }
}
