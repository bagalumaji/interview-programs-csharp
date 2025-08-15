namespace interview_programs_csharp.strings
{
    public class LongestSubstring
    {
        public static int LongestSubstringLength(string s)
        {
            int max = 0;
            var charSet = new HashSet<char>();
            int i = 0, j = 0;
            while (j < s.Length)
            {
                while (charSet.Contains(s[j]))
                {
                    charSet.Remove(s[i]);
                    i++;
                }
                charSet.Add(s[j]);
                //max = Math.Max(max, j - i + 1);
                max = Math.Max(max, charSet.Count);
                j++;
            }
            return max;
        }
    }
}
