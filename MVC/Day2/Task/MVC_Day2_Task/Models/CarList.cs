using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day2_Task.Models
{
    public class CarList
    {

        public static List<car> List = new List<car>() 
        {
            new car(1,"car1","model1","Manfacture1"),
            new car(2,"car2","model2","Manfacture2"),
            new car(3,"car3","model3","Manfacture3"),
            new car(4,"car4","model4","Manfacture4"),
            new car(5,"car5","model5","Manfacture5"),
            new car(6,"car6","model6","Manfacture6"),
            new car(7,"car7","model7","Manfacture7"),
            new car(8,"car8","model8","Manfacture8"),
            new car(9,"car9","model9","Manfacture9"),
        };


    }
}