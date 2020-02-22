using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace WebApp.Models
{
    public class Status
    {
        [PrimaryKey]
        [AutoIncrement] public int StatusId { get; set; }        
        public StatusEnums StatusEnum { get; set; }
#nullable enable
        [ForeignKey(typeof(User))]
        public string? UserId { get; set; }

        public virtual User User { get; set; }
        public IEnumerable<LostItem> LostItems { get; set; }
    }
    public enum StatusEnums
    {
        [Description("Найдено")]
        found = 0,
        [Description("Не найдено")]
        notfound = 1,
    }
}
