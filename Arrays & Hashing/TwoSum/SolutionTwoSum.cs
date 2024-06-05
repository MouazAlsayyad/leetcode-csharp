namespace Arrays___Hashing.TwoSum
{
    public static class SolutionTwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> prevMap = new Dictionary<int, int>(); // val index
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (prevMap.ContainsKey(diff))
                    return [prevMap[diff], i];
                prevMap[nums[i]] = i;
            }
            return [];
        }


    }
}
