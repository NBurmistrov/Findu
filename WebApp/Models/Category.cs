using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        [PrimaryKey]
        public int CategorysId { get; set; }
        public virtual IEnumerable<LostItem> LostItems { get; set; }

    }
}
