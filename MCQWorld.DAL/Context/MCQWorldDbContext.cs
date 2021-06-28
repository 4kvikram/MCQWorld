using MCQWorld.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCQWorld.DAL.Context
{
    public class MCQWorldDbContext : IdentityDbContext<ApplicationUser>
    {
        public MCQWorldDbContext(
           DbContextOptions<MCQWorldDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Questions> Questions{get; set;}


      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           // builder.Seed();
        }
    }
}
