using interview_programs_csharp.poco;

namespace interview_programs_csharp.comparer
{
    public class SortEmployeeByName : Comparer<Employee>
    {
        public override int Compare(Employee x, Employee y)
        {
           return x.Name.CompareTo(y.Name);
        }
    }

}
