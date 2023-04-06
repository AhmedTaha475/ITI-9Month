using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Day6_SD43_Task1_CodeFIrst.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please Enter the Name")]
        [MaxLength(30,ErrorMessage ="You Can't Enter More than 30 Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter the password")]
        [MinLength(6,ErrorMessage ="Not less than 6 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [Required(ErrorMessage ="Please enter email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}