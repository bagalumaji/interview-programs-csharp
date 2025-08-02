namespace interview_programs_csharp.arrays
{
    public class SortAndRemoveDuplicates1
    {
        public static int[] SortArrayAndRemoveDuplicates(int[] arr)
        {
            Array.Sort(arr);
            //arr.Distinct().ToArray();
            return [.. arr.Distinct()];
        }
    }
}
