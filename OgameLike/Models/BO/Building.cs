using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using OgameLike.Models.Validator;

namespace OgameLike.Models.BO
{
    public abstract class Building : IDbEntity
    {
        [MinLength(5), MaxLength(20)]
        public String name { get; set; }

        [MinValueValidator(minValue = 0)]
        public int? level { 
            get => level;
            set 
            {
                if (value >= 0)
                {
                    level = value;
                }
            } 
        }
        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int? CellNb { get => null; }
        

        public List<Resource> TotalCost { get => new List<Resource>(); }

        public List<Resource> NextCost {get => new List<Resource>(); }
    }
}