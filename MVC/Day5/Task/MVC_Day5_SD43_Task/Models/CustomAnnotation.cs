using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day5_SD43_Task.Models
{
    public class CustomAnnotation:ValidationAttribute/*,IClientValidatable*/
    {
        string value;
        public CustomAnnotation(string _value)
        {
            value = _value;
        }
        
        //public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        //{
        //    yield return new ModelClientValidationRule
        //    {
        //        ValidationType = "customannotation",
        //        ErrorMessage = this.ErrorMessage
        //    };
        //}

        public override bool IsValid(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                if(obj is string temp)
                {
                    if(temp==value)
                    {
                        return true;

                    }
                    else
                    {
                        ErrorMessage = $"Name must be : {value}";
                        return false;
                    }
                }
                else
                {
                    ErrorMessage = "Type Must Be String";
                    return false;
                }
            }
        }


    }
}