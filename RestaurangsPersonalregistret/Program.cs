namespace RestaurangsPersonalregistret
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EmployeeRegistry registry = new EmployeeRegistry();

            registry.AddEmployee("Boban", 25000);
            registry.AddEmployee("Maria", 30000);
            registry.AddEmployee("Elena", 35000);
            registry.AddEmployee("Alexia", 40000);
            registry.AddEmployee("Viktor", 45000);

            registry.PrintRegistry();
        }
    }

    class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary) 
        {
            Name = name;
            Salary = salary;
        }
    }

    class EmployeeRegistry
    {
        public List<Employee> employees;

        public EmployeeRegistry()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(string name, decimal salary)
        {
            employees.Add(new Employee(name, salary));
        }

        public void PrintRegistry()
        {
            Console.WriteLine("Employee Registry: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }
        }
    }
}
