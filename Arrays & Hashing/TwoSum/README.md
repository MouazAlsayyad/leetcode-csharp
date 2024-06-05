## TwoSum (C#)

This code implements a function named `TwoSum` that finds two numbers in an array that add up to a given target value.

### Problem Statement

Given an array of integers `nums` and a target integer `target`, the function finds two numbers in the array that add up to the `target` and returns their indices in the array. It assumes each input will have exactly one solution.

### Function Description

The `TwoSum` function takes an integer array `nums` and an integer `target` as input and returns an integer array of size 2 containing the indices of the two numbers that add up to the `target`. If no such numbers are found, the function returns an empty array `[]`.

### Implementation

1. **Hash Table for Lookups:** The function utilizes a dictionary, `prevMap`, to store previously encountered numbers and their corresponding indices in the array. This allows for efficient lookups in the next step.

2. **Iteration and Difference Calculation:** The function iterates through each element (`nums[i]`) in the array using a `for` loop. 
    - For each element, it calculates the difference between the `target` and the current element (`diff = target - nums[i]`).

3. **Checking for Complement:** 
    - The function checks if the `prevMap` dictionary already contains a key equal to the calculated `diff`.
        - If the key exists in `prevMap`, it means a previous element (`nums[prevMap[diff]]`) has been encountered that complements the current element (`nums[i]`) to reach the `target`. 
        - In this case, the function immediately returns an array containing the indices of both numbers: `[prevMap[diff], i]`. The first element is the index of the previously encountered number, and the second element is the current index.

4. **Storing Current Element:**  
    - If the `diff` is not found in `prevMap`, it signifies this is the first encounter with this number. The current element (`nums[i]`) and its index (`i`) are added to the `prevMap` for potential future lookups.

5. **No Solution Found:** After iterating through the entire array, if no match is found in `prevMap`, it implies there are no two numbers that add up to the `target`. The function then returns an empty array `[]` to indicate this case.

### Time Complexity

The time complexity of this function is O(n), where n is the length of the input array. This is because the loop iterates through the array once, and the lookups and insertions in the hash table have an average constant time complexity.

### Space Complexity

The space complexity of this function is O(n) in the worst case scenario. This is because the `prevMap` can grow up to n elements in size if no two numbers add up to the target and all unique numbers are encountered. However, in cases where a solution is found earlier, the space complexity will be lower.


### Related Problems

* 1. Two Sum [https://leetcode.com/problems/two-sum/]
