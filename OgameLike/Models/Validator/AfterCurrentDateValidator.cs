using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgameLike.Models.Validator
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]

    public class AfterCurrentDateValidator : ValidationAttribute
    {
 
        public override bool IsValid(object value)
        {
            return ((DateTime)value>=DateTime.Now);

        }
        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}