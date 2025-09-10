using System.ComponentModel.DataAnnotations; // to configure behavior

namespace DOTNET
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
}