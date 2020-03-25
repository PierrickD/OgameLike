using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public String name { get; set; }
        public int? lastQuantity { get; set; }
        public DateTime lastUpdate { get; set; }

        public DateTime currentDate()
        {
            return DateTime.Now;
        }
    }
}