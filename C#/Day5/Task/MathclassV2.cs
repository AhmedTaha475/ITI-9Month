using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
    static class MathclassV2
    {
        public static double add(double x, double y)
        {
            return x + y;
        }

        public static double subtract(double x, double y) { return x - y; }

        public static double multiply(double x, double y) { return x * y; }

        public static double divide(double x, double y)
        {

            if (y == 0) return -1;
            else
                return x / y;


        }
    }
}
