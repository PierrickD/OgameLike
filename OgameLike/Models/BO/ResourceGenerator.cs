using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgameLike.Models.BO
{
    public abstract class ResourceGenerator:Building
    {
        public List<Resource> ResourceBySecond { get => new List<Resource>(); }
    }
}