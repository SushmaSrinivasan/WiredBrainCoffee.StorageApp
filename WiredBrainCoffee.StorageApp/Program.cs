using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var OrganizationRepository = new GenericRepository<Organization>();
            AddOrganizations(OrganizationRepository);

            Console.ReadLine();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2 is:{employee.FirstName}");
        }

        private static void AddOrganizations(GenericRepository<Organization> OrganizationRepository)
        {
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "Globomantics" });
            OrganizationRepository.Save();
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();
        }
    }
}