using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Statuses
    {
        public int StatusId { get; set; }
        public StatusEnum StatusEnum { get; set; }
        public string? UserId { get; set; }
    }
}
