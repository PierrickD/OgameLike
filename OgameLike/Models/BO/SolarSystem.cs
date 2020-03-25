using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgameLike.Models.BO
{
    public class SolarSystem : IDbEntity
    {
        [MinLength(5),MaxLength(20)]
        public String name { get; set; }

        public List<Planet> planetsList;
        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}