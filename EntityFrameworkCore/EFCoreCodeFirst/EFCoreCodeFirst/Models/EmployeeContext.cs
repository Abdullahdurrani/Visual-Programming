using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    // DbContext corresponds to your database
    // DbContext object is used to access tables and views (which will be represented by DbSet's)
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }

        // DbSet refers to table or view in database
        // DbSet is used to CRUD your table data.
        public DbSet<Employee> Employees { get; set; }

        // To seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "abd",
                    LastName = "durrani",
                    Email = "abd@email",
                    DateofBirth = new DateTime(2000, 01, 01),
                    PhoneNumber = "123-123-123"
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "ahti",
                    LastName = "mughal",
                    Email = "ahti@email",
                    DateofBirth = new DateTime(1998, 02, 03),
                    PhoneNumber = "999-999-999"
                }
                );
        }
    }
}
