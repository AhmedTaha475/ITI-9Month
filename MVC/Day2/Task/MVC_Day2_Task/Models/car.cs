using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day2_Task.Models
{
    public class car
    {

        public int Num { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public string Manfacture { get; set; }


        public car(int num ,string color,string model,string man )
        {   
            Num = num;
            Color = color;
            Model = model;
            Manfacture = man;
            
        }
    }
}