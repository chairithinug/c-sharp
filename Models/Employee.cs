using System.ComponentModel.DataAnnotations; // to configure behavior

namespace HRApp.Models
{
    public class Employee
    {
        [Key] // Data Annotations, explicitly specify Primary Key
        public int EmployeeID { get; set; } // EFCore auto make this Primary Key by convention
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentID { get; set; } // Foreign Key

        // setup the relationships, links to Department entity
        public Department Department { get; set; } // Navigation property (one-to-many relationship, each employee belongs to a department, but a department can have many employees)
    }

    public class HRDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } // mapping to Employees table
        public DbSet<Department> Departments { get; set; } // mapping to Departments table

        // configure the relationships using Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.property(e => e.LastName).IsRequired().HasMaxLength(50);
            });
        }
    }
}