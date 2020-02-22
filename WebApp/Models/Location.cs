using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WebApp.Models
{
    public class Location
    {
        [PrimaryKey]
        [AutoIncrement] public int LocationId { get; set; }
        public virtual IEnumerable<LostItem> LostItem { get; set; }

    }
}
