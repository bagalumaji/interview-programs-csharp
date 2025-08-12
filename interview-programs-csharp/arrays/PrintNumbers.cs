namespace interview_programs_csharp.arrays
{
    public class PrintNumbers
    {
        public static void PrintNumbersInRange(int[]arr)
        {
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i-2]+1 == arr[i-1] && arr[i-1]+1 == arr[i])
                {
                    Console.WriteLine(arr[i-2] + " " + arr[i-1]+" " + arr[i]);
                }
            }
        }
    }
}
