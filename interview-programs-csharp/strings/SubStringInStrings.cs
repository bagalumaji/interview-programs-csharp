namespace interview_programs_csharp.strings
{
    internal class SubStringInStrings
    {
        public static string FindSbStringInString(String[] str)
        {
            string s1 = "";
            string s2 = "";
            string s = str[0];
            string[] words = str[1].Split(',');
            foreach (string word in words)
            {
                int l = word.Length;
                if (s.StartsWith(word) && s1.Length < l)
                {
                    s1 = word;
                }
                else if (s.EndsWith(word) && s2.Length < l)
                {
                    s2 = word;
                }
            }

            return s1 + "," + s2;
        }
    }

}
