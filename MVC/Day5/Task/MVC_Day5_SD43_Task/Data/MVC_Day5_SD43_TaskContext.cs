using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Day5_SD43_Task.Data
{
    public class MVC_Day5_SD43_TaskContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_Day5_SD43_TaskContext() : base("name=MVC_Day5_SD43_TaskContext")
        {
        }

        public System.Data.Entity.DbSet<MVC_Day5_SD43_Task.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MVC_Day5_SD43_Task.Models.Orders> Orders { get; set; }

       
    }
}
