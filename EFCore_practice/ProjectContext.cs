using EFCore_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_practice
{
    public class ProjectContext : DbContext //oop inhertance
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }

        //connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=Abdullah\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
