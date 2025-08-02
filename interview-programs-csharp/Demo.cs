using interview_programs_csharp.arrays;

namespace interview_programs_csharp
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 1, 2, 3, 4,6, 2, 4, 5 };
            int[] result = SortAndRemoveDuplicates1.SortArrayAndRemoveDuplicates(arr);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //arr = SortAndRemoveDuplicates.SortArray(arr);
            //int l = SortAndRemoveDuplicates.RemoveDuplicates(arr);

            //for (int i = 0; i < l; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

        }
    }
}
