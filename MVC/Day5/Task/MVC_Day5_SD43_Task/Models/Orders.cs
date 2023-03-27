using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace MVC_Day5_SD43_Task.Models
{

    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter the date")]
        [Display(Name ="Purchase Date")]
        [DataType(DataType.Date)]
        
        public DateTime Date { get; set; }

        [Required(ErrorMessage ="Please enter the price")]
        [Range(0,10_000,ErrorMessage ="Price must be inside 0 to 10_000 range")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int custID { get; set; }
        public Customer Customer { get; set; }
    }
}