using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgameLike.Models.BO
{
    public class SolarSystem : IDbEntity
    {
        public String name { get; set; }

        public List<Planet> planetsList;
        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}