namespace interview_programs_csharp.arrays
{
    public class AllPairsOfSums
    {
        public static Dictionary<int,int> AllSumPairs(int[]arr,int target)
        {
            var pairs = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                var val = target - arr[i];
                if(!pairs.ContainsKey(val) && !pairs.ContainsValue(val))
                {
                    pairs.Add(arr[i], val);
                }
            }
            Console.WriteLine(pairs);
            return pairs;
        }
    }
}
