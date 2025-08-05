namespace interview_programs_csharp.arrays
{
    public class SortAndRemoveDuplicates
    {
        public static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }

        public static int RemoveDuplicates(int[] arr)
        {
            int i = 0, j = 1;
            while (j < arr.Length)
            {
                if (arr[i] != arr[j])
                {
                    i++;
                    arr[i] = arr[j];
                }
                j++;
            }
            return i + 1;
        }

        public static int[] RemoveDuplicatesWithSet(int[] arr)
        {
            HashSet<int> set = [.. arr];
            int[] newArray = [.. set];
            return newArray;
        }
        public static int[] RemoveDuplicatesWithLINQ(int[] arr)
        {
            return [.. arr.Distinct()];
        }
        public static void SortArrayWothSortMethod(int[] arr)
        {
            Array.Sort(arr);
        }
    }
}
