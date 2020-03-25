using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgameLike.Models.Validator
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]

    public class MinValueValidator : ValidationAttribute
    {
        public object minValue { get; set; }
 
        public override bool IsValid(object value)
        {
            if(value.GetType() == typeof(int) && minValue.GetType() == typeof(int))
            {
                return ((int)value >= (int)minValue);
            }
            if (value.GetType() == typeof(DateTime) && minValue.GetType() == typeof(DateTime))
            {
                return ((DateTime)value >=(DateTime)minValue);
            }
            return false;

        }
        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }
    }
}