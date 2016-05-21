using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BricejModels;
using BriceSite.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BriceSite.Context
{
    public class BricejContext : DbContext
    {
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Programming> Programming { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}