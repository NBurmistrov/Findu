using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        [PrimaryKey]
        public Guid CategorysId { get; set; }
        public string Type { get; set; }
        public virtual IEnumerable<LostItem> LostItems { get; set; }

    }
}
