using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LostItem> LostItems { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Define composite key.
            builder.Entity<Category>()
                .HasKey(en => new { en.CategorysId });
            builder.Entity<Location>()
                .HasKey(en => new { en.LocationId});
            builder.Entity<LostItem>()
                .HasKey(en => new { en.LocationId });
            builder.Entity<Status>()
                .HasKey(en => new { en.StatusId });
        }
    }
}
