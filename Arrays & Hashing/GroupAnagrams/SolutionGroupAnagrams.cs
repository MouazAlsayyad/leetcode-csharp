namespace Arrays___Hashing.GroupAnagrams
{
    public static class SolutionGroupAnagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagramMap = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var count = new int[26];

                foreach (var c in str)
                    count[c - 'a']++;

                var key = string.Join("#", count);

                if (!anagramMap.ContainsKey(key))
                    anagramMap[key] = new List<string>();

                anagramMap[key].Add(str);
            }
            return [.. anagramMap.Values];

        }


    }
}
