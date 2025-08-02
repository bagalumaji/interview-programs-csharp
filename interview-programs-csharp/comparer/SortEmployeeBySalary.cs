using interview_programs_csharp.poco;

namespace interview_programs_csharp.comparer
{
    public class SortEmployeeBySalary : Comparer<Employee>
    {
        public override int Compare(Employee? e1, Employee? e2)
        {
            var res = e1.Salary - e2.Salary;
            if (res == 0)
            {
                res = e1.Name.CompareTo(e2.Name);
            }
            return res;
        }
    }
}
