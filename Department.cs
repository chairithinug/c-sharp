namespace DOTNET.Models
{
    public class Department
    {
        public int DepartmentID { get; set; } // EFCore auto make this Primary Key by convention
        public string Name { get; set; }

        // setup the relationships, links to Employee entity
        public List<Employee> Employees { get; set; } // Navigation property (one-to-many relationship, each department can have many employees)
    }
}