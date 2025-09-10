using DOTNET;

var context = new CompanyContext();

var department = new Department { Name = "Engineering" };
context.Departments.Add(
    new Department
    {
        Name = "Engineering",
        Employees = new List<Employee>
        {
            new Employee {
                FirstName = "Marissa",
                LastName = "Johanssen",
                HireDate = DateTime.Now,
            },
            new Employee {
                FirstName = "Ryan",
                LastName = "Smith",
                HireDate = DateTime.Now,
            }
        }
    }
);
context.SaveChanges();

var employees = context.Employees
    .Where(e => e.Department.Name == "Engineering")
    .ToList();
Console.WriteLine($"Employees in Engineering: {employees.Count}");

// dotnet ef migrations add InitialCreate
// dotnet ef database update
// dotnet run