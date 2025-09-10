using Microsoft.EntityFrameworkCore; // DbContext, DbSet, ModelBuilder

namespace DOTNET
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } // mapping to Employees table
        public DbSet<Department> Departments { get; set; } // mapping to Departments table

        // configure the relationships using Fluent API
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Employee>(entity =>
        //     {
        //         entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
        //         entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
        //     });
        // }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Company.db");
        }
    }
}