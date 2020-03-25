using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgameLike.Models.Validator
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]

    public class MaxValueValidator : ValidationAttribute
    {
        public object maxValue { get; set; }
 
        public override bool IsValid(object value)
        {
            if(value.GetType() == typeof(int) && maxValue.GetType() == typeof(int))
            {
                return ((int)value <= (int)maxValue);
            }
            if (value.GetType() == typeof(DateTime) && maxValue.GetType() == typeof(DateTime))
            {
                return ((DateTime)value <=(DateTime)maxValue);
            }
            return false;

        }
        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}