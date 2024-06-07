namespace Arrays___Hashing.LongestConsecutiveSequence
{
    internal static class SolutionLongestConsecutiveSequence
    {
        public static int LongestConsecutiveSequence(int[] nums)
        {
            // Use a HashSet for faster membership checks
            HashSet<int> numSet = new HashSet<int>(nums);
            int longestSeq = 0;

            // Iterate through each number in the set
            foreach (int num in numSet)
            {
                // Check if the previous number is not in the set (potential sequence start)
                if (!numSet.Contains(num - 1))
                {
                    int currentSeq = 1;
                    // Keep incrementing the current sequence length as long as the next number exists
                    while (numSet.Contains(num + currentSeq))
                    {
                        currentSeq++;
                    }
                    // Update the longest sequence if the current sequence is longer
                    longestSeq = Math.Max(longestSeq, currentSeq);
                }
            }

            return longestSeq;
        }
    }
}
