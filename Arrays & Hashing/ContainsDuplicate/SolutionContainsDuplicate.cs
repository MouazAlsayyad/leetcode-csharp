namespace Arrays___Hashing.ContainsDuplicate
{
    public static class SolutionContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> directions = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (directions.Contains(nums[i])) return true;
                else directions.Add(nums[i]);
            }
            return false;
        }
    }
}
