using interview_programs_csharp.arrays;

namespace interview_programs_csharp
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 1, 2, 4, 5, 4, 3, 1 };
            Console.WriteLine("before removing duplicates:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            int [] removedDuplicates = SortAndRemoveDuplicates.RemoveDuplicatesWithLINQ(arr);
            Console.WriteLine("\nArray after removing duplicates:");
            foreach (var item in removedDuplicates)
            {
                Console.Write(item + " ");
            }
           
            SortAndRemoveDuplicates.SortArrayWothSortMethod(removedDuplicates);
            Console.WriteLine("\nSorted array:");
            foreach (var item in removedDuplicates)
            {
                Console.Write(item + " ");
            }

        }
    }
}
