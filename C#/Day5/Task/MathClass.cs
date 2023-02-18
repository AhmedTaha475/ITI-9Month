using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
     class MathClass
    {

        public  double add (double x,double y)
        {
            return x + y;
        }

        public  double subtract (double x,double y) { return x - y; }

        public  double multiply (double x,double y) { return x * y; }

        public  double divide(double x, double y) {

            if (y == 0) return -1;
            else
            return x / y; 
        
        
        }



    }
}
