namespace Arrays___Hashing.IsAnagram
{
    public static class SolutionIsAnagram
    {
        public static bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) return false;

            Dictionary<char, int> countMapS = new Dictionary<char, int>();
            Dictionary<char, int> countMapT = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (!countMapS.ContainsKey(charS))
                    countMapS[charS] = 0;

                if (!countMapT.ContainsKey(charT))
                    countMapT[charT] = 0;

                countMapS[charS]++;
                countMapT[charT]++;
            }

            // Check if both maps have the same keys with the same counts
            foreach (var kvp in countMapS)
                if (!countMapT.ContainsKey(kvp.Key) || countMapT[kvp.Key] != kvp.Value)
                    return false;

            return true;
        }
    }
}
