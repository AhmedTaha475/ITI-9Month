using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day2_Task.Models
{
    public class imageClass
    {

        public string id { get; set; }

        public string name { get; set; }

        public string image { get; set; }

        public imageClass( string _id,string _name,string _image)
        {
            id = _id;
            name = _name;
            image = _image;
                    
        }
    }
}