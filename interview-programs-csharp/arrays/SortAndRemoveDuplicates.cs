namespace interview_programs_csharp.arrays
{
    public class SortAndRemoveDuplicates
    {
        static int[] SortArray(int[] arr)
        {
           for(int i=0;i<arr.Length;i++)
            {
                for (int j=0;j<arr.Length;j++)
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

        static int RemoveDuplicates(int[] arr)
        {
            int i = 0, j = 1;
            while (j<arr.Length)
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
        public static void Main(string[] args)
        {
            int[] arr = {3,1,2,3,4,2,4,5};
            arr = SortArray(arr);
            int l=RemoveDuplicates(arr);

            for (int i = 0; i < l; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
