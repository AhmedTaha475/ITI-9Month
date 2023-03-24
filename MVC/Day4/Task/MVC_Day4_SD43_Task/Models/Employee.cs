using MVC_Day4_SD43_Task.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MVC_Day4_SD43_Task.Models
{

     public enum Gender { male,female}
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int empID { get; set; }

        [Required(ErrorMessage ="Please enter the name")]
        [MaxLength(30,ErrorMessage ="Max length is 30")]
        [Display(Name="Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter user name")]
        [MaxLength(25, ErrorMessage = "Max length is 25")]
        //[MinAge(25, ErrorMessage = "Ay 7aga rbna ykrmk")]
        public string username { get; set; }

        [Required(ErrorMessage ="Please enter password")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage ="Not less than 4 char")]
        [MaxLength(10,ErrorMessage ="Not more than 10 char ")]
        public string password { get; set; }

        [Required(ErrorMessage ="Please choose gender")]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage ="Please enter salary")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage ="Please enter join Date")]
        [DataType(DataType.Date)]
        public DateTime joinDate { get; set; }

        [Required(ErrorMessage ="Please enter Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not valid.")]
        public string email { get; set; }

        [Display(Name="Phone Number")]
        [Required(ErrorMessage ="Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }
    }
}