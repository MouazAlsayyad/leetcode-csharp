namespace Arrays___Hashing.TopKFrequent
{
    public static class SolutionTopKFrequent
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            // Count frequency of each number
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            // Sort the map entries by frequency in descending order
            var sortedItems = frequencyMap.OrderByDescending(x => x.Value);

            // Return the first 'k' elements from the sorted entries
            return sortedItems.Take(k).Select(x => x.Key).ToArray();
        }
    }
}
