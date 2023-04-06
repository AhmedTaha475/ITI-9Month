using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Day6_SD43_Task1_CodeFIrst.Models
{
    public class IdentityContext:DbContext
    {

        public IdentityContext():base("myConn")
        {
            
        }
        public DbSet<Client> Clients { get; set; }
    }
}