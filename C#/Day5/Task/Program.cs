using System.Numerics;

namespace D5SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TaskFrom 1-6
            ////1- created class point and point3d inherits from it
            ////2-override the tostring method in point3d and console it
            ////3-create explicit casting operator for string in point3d
            //Point3D p = new(10, 10, 10);
            //Console.WriteLine(p.ToString());
            //string str = (string)p;
            //Console.WriteLine("After the explicit casting");
            //Console.WriteLine(str);

            ////4-take inputs from user for p1,p2

            //Point p1, p2;
            //int x, y;

            //Console.WriteLine($"Enter point number 1");
            //do
            //{
            //    Console.WriteLine("x:");

            //} while (!int.TryParse(Console.ReadLine(), out x));


            //do
            //{
            //    Console.WriteLine("y:");

            //} while (!int.TryParse(Console.ReadLine(), out y));

            //p1 = new(x, y);

            //Console.WriteLine($"Enter point number 2");
            //do
            //{
            //    Console.WriteLine("x:");

            //} while (!int.TryParse(Console.ReadLine(), out x));


            //do
            //{
            //    Console.WriteLine("y:");

            //} while (!int.TryParse(Console.ReadLine(), out y));
            //p2 = new(x, y);

            //Console.WriteLine("p1 is: " + p1);
            //Console.WriteLine("p2 is: " + p2);
            ////p1 == p2;  will cause compilation error till i override == operating
            //Console.WriteLine(p1.Equals(p2));

            #endregion

            #region Task from 7-9

            //task7
            //MathClass m = new MathClass();
            //Console.WriteLine(m.add(5, 10));
            //Console.WriteLine(m.subtract(5, 10));
            //Console.WriteLine(m.multiply(5, 10));
            //Console.WriteLine(m.divide(5, 10));
            //Console.WriteLine("===============================");
            //task 8
            //Console.WriteLine(MathclassV2.add(5, 10));
            //Console.WriteLine(MathclassV2.subtract(5, 10));
            //Console.WriteLine(MathclassV2.multiply(5, 10));
            //Console.WriteLine(MathclassV2.divide(5, 10));
            //Console.WriteLine("===============================");
            //task 9
            //NIC obj1 = new NIC(); can't call new obj from that class
            //NIC obj1 = NIC.singleToneObj;
            //NIC obj2 = new NIC();
            //Console.WriteLine(obj1.Manufacture);
            //Console.WriteLine(obj1.MacAddress);
            //Console.WriteLine(obj1.Type);




            #endregion

            #region Duration

            //// duration class
            ////    Duration d1=new Duration(1,10,15);
            ////Console.WriteLine(d1.ToString());
            ////    Duration d2 = new(3600);
            ////Console.WriteLine(d2);
            ////    Duration d3 = new(666);
            ////Console.WriteLine(d3);
            ////    Duration d4 = new(2, 10, 0);
            ////Console.WriteLine(d4.TotalTimeInSec);
            //Duration d1 = new Duration(1, 50, 30);
            //Duration d2 = new Duration(2, 30, 30);
            //Console.WriteLine("d1 is :" + d1);
            //Console.WriteLine("d2 is :" + d2);
            //Console.WriteLine(d1.TotalTimeInSec);
            //Console.WriteLine(d2.TotalTimeInSec);
            ////Duration d3 = new Duration(6630 + 9030);
            //Duration d3 = d1 + d2;
            //Console.WriteLine(d3);
            //d3 = d1 + 7800;
            //Console.WriteLine(d3);
            //Console.WriteLine(d3.TotalTimeInSec);
            ////Console.WriteLine(new Duration(14430+666));
            //d3 = 666 + d3;
            //Console.WriteLine(d3);
            //d3 = d1++;
            //Console.WriteLine("d3 is :" + d3);
            //Console.WriteLine("d1 is : " + d1);
            //d3 = --d2;
            //Console.WriteLine("d3 is :" + d3);
            //Console.WriteLine("d2 is : " + d2);
            ////d3 = -d2; i don't understand that one
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d1 > d2);
            //Console.WriteLine(d1 <= d2);
            ////if(d1) i don;t understand that as well
            //DateTime obj = (DateTime)d1;
            //Console.WriteLine(obj.ToString());
            //if(d1)
            //{
            //    Console.WriteLine("true");
            //}
            //else { Console.WriteLine("false"); }
            #endregion


            //Duration d1 = new Duration(-500);
            //Duration d2 = new Duration(7000);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Duration d3 = -d2;
            //Console.WriteLine(d3.TotalTimeInSec);
            //Duration d1=new Duration(25,20,30);
            //DateTime d2=(DateTime)d1;
            //Console.WriteLine(d2.ToString());
            //DateTime d1 = new DateTime(2005, 11, 30, 23, 59, 59);

            Duration d1 = new Duration(6500);
            Duration d3;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.GetHashCode());
            //d3=d1++;
            //Console.WriteLine(d1.GetHashCode());
            //Console.WriteLine(d3.GetHashCode());
            //Console.WriteLine(d1);
            //Console.WriteLine(d3);

            //Console.WriteLine(d1.GetHashCode());
            //d3 = d1++;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.GetHashCode());
            //Console.WriteLine(d3.GetHashCode());
            //Console.WriteLine(d3);
        }

   
    }


}