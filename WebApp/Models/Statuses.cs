using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Statuses
    {
        public int StatusId { get; set; }
        public StatusEnums StatusEnum { get; set; }
        public string? UserId { get; set; }
        public enum StatusEnums
        {
            [Description("Найдено")]
            found = 0 ,
            [Description("Не найдено")]
            notfound = 1,
        }
    }
}
