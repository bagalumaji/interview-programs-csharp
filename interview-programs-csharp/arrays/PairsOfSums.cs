namespace interview_programs_csharp.arrays
{
    public class PairsOfSums
    {
        public static int[] PairOfSumFromArray(int[]arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return new int[] { arr[i], arr[j] };
                    }
                }
            }
            return new int[] { };
        }
    }
}
