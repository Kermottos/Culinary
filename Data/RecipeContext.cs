using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CulinaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CulinaryApp.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
        }
    }
}
