using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using OgameLike.Models.Validator;

namespace OgameLike.Models.BO
{
    public class Resource : IDbEntity
    {

        public Resource(String name, int? lastQuantity)
        {
            this.name = name;
            this.lastQuantity = lastQuantity;
            this.lastUpdate = currentDate();
        }
        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MinLength(5), MaxLength(20)]
        public String name { get; set; }

        [MinValueValidator(minValue = 0)]
        public int? lastQuantity
        {
            get=>lastQuantity;
            set
            {
                if (value >= 0)
                {
                    lastQuantity = value;
                }
            }
        }

        [AfterCurrentDateValidator()]
        public DateTime lastUpdate {
            get => lastUpdate;
            set 
            {
                if (value >= DateTime.Now)
                {
                    lastUpdate = value;
                }
            } 
        }

        public DateTime currentDate()
        {
            return DateTime.Now;
        }
    }
}