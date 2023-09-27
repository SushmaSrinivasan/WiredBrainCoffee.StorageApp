using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            var OrganizationRepository = new ListRepository<Organization>();
            AddOrganizations(OrganizationRepository);
            WriteAllToConsole(organizationRepository);

            IRepository<IEntity> repo = new ListRepository<Organization>();

            Console.ReadLine();
        }

        private static void WriteAllToConsole(IRepository<IEntity> repository)
        {
            var items=repository.GetAll();
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2 is:{employee.FirstName}");
        }

        private static void AddOrganizations(IRepository<Organization> OrganizationRepository)
        {
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "Globomantics" });
            OrganizationRepository.Save();
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();
        }
    }
}