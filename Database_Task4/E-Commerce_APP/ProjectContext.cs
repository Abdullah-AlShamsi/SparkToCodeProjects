using E_Commerce_APP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_APP
{
    public class ProjectContext : DbContext
    {
        //1- register models
        public DbSet<User> users { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Review> Reviews { get; set; }


        //2- connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=.;Database=E_Commerce_DB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
