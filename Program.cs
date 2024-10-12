using System.Security.Cryptography.X509Certificates;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
          {
              new Employee { Id=1, Name = "John", Salary = 3000 },
              new Employee { Id=2, Name = "Alic", Salary = 500 },
              new Employee { Id=3, Name = "Bob",  Salary = 25000 },
              new Employee { Id=4, Name = "Eve",  Salary = 7000 },

          };

            Console.WriteLine("orginal list of employee");
            DisplayEmployees(employees);
            var sortedByName = employees.OrderBy(x => x.Name).ToList();
            Console.WriteLine("sorted list of employee By name");
            DisplayEmployees(sortedByName);
            var sortedBySalary = employees.OrderBy(x =>x.Salary).ToList();
            Console.WriteLine("sorted list of employee By Salary");
            DisplayEmployees(sortedBySalary);






        }
        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees) 
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}"+ $"Salary: {employee.Salary:C}");
            }
            Console.WriteLine();

        }
    }
}