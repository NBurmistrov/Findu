using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WebApp.Models
{
    public class LostItem
    {
        [PrimaryKey]
        public Guid ItemId { get; set; }
        [ForeignKey(typeof(User))]
        public Guid UserId { get; set; }
        [ForeignKey(typeof(Category))]
        public Guid CategoryId { get; set; }
        [ForeignKey(typeof(Location))]
        public Guid LocationId { get; set; }
        [ForeignKey(typeof(Status))]
        public Guid StatusId { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }

    }
}
