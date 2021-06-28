using MCQWorld.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCQWorld.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>().HasData(
                    new Questions
                    {
                       QuestionId = 1,
                        CreatedOn = DateTime.Now,
                        Description = "test",
                        Status = 1
                    },
                    new Questions
                    {
                       QuestionId = 2,
                        CreatedOn = DateTime.Now,
                        Description = "test one",
                        Status = 1
                    }
                );
            
        }
    }
}
