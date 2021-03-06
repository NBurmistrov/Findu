﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User : IdentityUser
    {        
        public string Surname { get; set; }
        public string Name { get; set; }
#nullable enable        
        public string? Patronymic { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual IEnumerable<LostItem> LostItems { get; set; }
        public virtual IEnumerable<Status> Statuses { get; set; }


    }
}
