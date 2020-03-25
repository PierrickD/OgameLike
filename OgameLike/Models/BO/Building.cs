using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgameLike.Models.BO
{
    public abstract class Building : IDbEntity
    {
        public String name { get; set; }
        public int? level { get; set; }
        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int? CellNb()
        {
            return 0;
        }

        public List<Resource> TotalCost()
        {
            return null;
        }

        public List<Resource> NextCost()
        {
            return null;
        }
    }
}