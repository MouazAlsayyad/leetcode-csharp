
## Top K Frequent Elements (C#)

This repository provides a solution to the **Top K Frequent Elements** problem in C#. The problem is to identify the k most frequent elements in a given array.

### Problem Statement

Given an array of integers `nums` and a positive integer `k`, return an array of the `k` most frequent elements in the array.

**Example:**

```c#
Input: nums = [1, 1, 1, 2, 2, 3], k = 2
Output: [1, 2]
```

**Constraints:**

* `1 <= nums.length <= 10^5`
* `0 <= nums[i] <= 10^5`
* `1 <= k <= the number of unique elements in the array`

### Solution

The solution utilizes a hash table to efficiently count the frequency of each element in the array. The hash table is then sorted by frequency in descending order, and the top `k` elements are extracted and returned.

### Implementation

```c#
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
```

### Time Complexity

The time complexity of the solution is O(n + k log n), where n is the length of the input array and k is the number of elements to return.

### Space Complexity

The space complexity of the solution is O(n), where n is the length of the input array.

### Related Problems

* Top K Frequent Elements [https://leetcode.com/problems/top-k-frequent-elements/]