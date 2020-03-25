using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLike.Models.BO
{
    public interface IDbEntity
    {
        long? id { get; set; }
    }
}
