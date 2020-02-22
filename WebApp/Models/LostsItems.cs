using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class LostsItems
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Categories> Categories { get; set; }
        public virtual IEnumerable<Locations> Locations { get; set; }
        public virtual IEnumerable<Statuses> Statuses { get; set; }
        public virtual IEnumerable<User> Users { get; set; }

    }
}
