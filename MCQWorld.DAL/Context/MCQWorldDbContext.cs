using MCQWorld.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCQWorld.DAL.Context
{
    /// <summary>
    ///  see :  https://www.c-sharpcorner.com/article/seed-data-in-net-core-identity/
    /// </summary>
    public class MCQWorldDbContext : IdentityDbContext<ApplicationUser>
    {
        public MCQWorldDbContext(
           DbContextOptions<MCQWorldDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Questions> Questions { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
