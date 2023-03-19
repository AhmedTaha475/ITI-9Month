using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day1_SD43_Task
{
    public class Products
    {
        public int id { get; set; }

        public string name { get; set; }
        public Products(int _id, string _name)
        {
            
              this.id = _id;
            this.name = _name;
        }
    }
}