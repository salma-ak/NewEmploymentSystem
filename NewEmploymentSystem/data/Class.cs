using EmployeeManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Numerics;

namespace EmployeeManagement.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure default schema
            modelBuilder.HasDefaultSchema("dbo");


            //  modelBuilder.Seed();
        }



        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
