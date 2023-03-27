using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Day5_SD43_Task.Models
{
    public enum Gender { male,female}

    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int custID { get; set; }

        [Required(ErrorMessage ="Please enter Customer Name")]
        [MaxLength(12,ErrorMessage ="Not more than 12 characters")]
        [MinLength(3,ErrorMessage ="Not less than 3 characters")]
        [CustomAnnotation("AhmedTT")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please choose your gender")]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage ="Please enter mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not valid.")]
        public string email { get; set; }

        [Required(ErrorMessage ="Please enter the phone number")]
        [Display(Name="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^01[0125][0-9]{8}$", ErrorMessage ="Please enter correct phone number 011|010|012|015 ________")]
        
        public string phoneNum { get; set; }

        public virtual HashSet<Orders> orders { get; set; }=new HashSet<Orders>();
    }
}