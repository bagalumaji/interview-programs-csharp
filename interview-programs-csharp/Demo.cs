using interview_programs_csharp.comparer;
using interview_programs_csharp.poco;

namespace interview_programs_csharp
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Sayaji", 60000));
            employees.Add(new Employee("Ramesh", 50000));
            employees.Add(new Employee("Raj", 60000));
            employees.Add(new Employee("Sharu", 5000));

            Console.WriteLine("Before sorting:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            //employees.Sort(new SortEmployeeByName());
            employees.Sort(new SortEmployeeBySalary());

            Console.WriteLine("After sorting by name:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
