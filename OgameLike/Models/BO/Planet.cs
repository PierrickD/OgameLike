using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OgameLike.Models.Validator;
using System.Linq;
using System.Web;

namespace OgameLike.Models.BO
{
    public class Planet : IDbEntity
    {
        public Planet()
        {
            ressourcesList = new List<Resource>();
            ressourcesList.Add(new Resource("Energie", 0));
            ressourcesList.Add(new Resource("Oxygene", 0));
            ressourcesList.Add(new Resource("Acier", 0));
            ressourcesList.Add(new Resource("Uranium", 0));
        }


        public long? id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MinLength(5), MaxLength(20)]
        public String name { get; set; }

        [MinValueValidator(minValue=0)]
        public int? caseNb {
            get 
            { 
                return caseNb; 
            } 
            set 
            {
                if (value >= 0)
                {
                    caseNb = value;
                }
            } 
        }

        [MaxLength(4)]
        public List<Resource> ressourcesList { get; set; }

        public List<Building> buildingsList { get; set; }


    }
}