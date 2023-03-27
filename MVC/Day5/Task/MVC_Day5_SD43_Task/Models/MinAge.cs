using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Day5_SD43_Task.Models
{
    public class MinAge:ValidationAttribute
    {
        int value;

        public MinAge(int _value)
        {
            value = _value;
        }

        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is int temp)
                {
                    if (temp > value)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "Please enter age above 18";
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

        }
    }
}