using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Domain
{
     public class EFContext: DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<Food> Foods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var con = "";//ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            var x = ConfigurationManager.ConnectionStrings["MyConnection"];
            if (x != null)
            {
                con = x.ConnectionString;
            }
            
            if (string.IsNullOrEmpty(con))
            {
                con = "Server=91.238.103.51;Port=5743;Database=treeviewdb;Username=treeviewuser;Password=$544$B76fedede7w**G)K$t!Ube22}xk";
            }
            optionsBuilder.UseNpgsql(con.ToString());
        }
    }
}
