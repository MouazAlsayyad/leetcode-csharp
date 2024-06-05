## ContainsDuplicate (C#)

This code implements a function named `ContainsDuplicate` that determines if an array contains duplicate elements.

### Problem Statement

Given an integer array `nums`, the function checks if there are any duplicate integers (elements appearing more than once) in the array.

### Function Description

The `ContainsDuplicate` function takes an integer array `nums` as input and returns `true` if the array contains any duplicates, otherwise it returns `false`.

### Implementation

1. **Hash Set:** The function utilizes a `HashSet<int>` named `directions` to store unique elements encountered during iteration. Hash sets have a constant-time lookup for existence, making them efficient for duplicate detection.

2. **Iteration and Check:** The function iterates through each element (`nums[i]`) in the array using a `for` loop:
    - It checks if the current element (`nums[i]`) already exists in the `directions` set.
        - If the element is found in the set, it means a duplicate has been encountered, and the function immediately returns `true`.

3. **Adding Unique Elements:**  
    - If the element is not found in the set, it signifies it's the first occurrence. The element is then added to the `directions` set for future reference.

4. **No Duplicates:** After iterating through the entire array, if no element was found in the set before adding it, the function concludes there are no duplicates and returns `false`.

### Time Complexity

The time complexity of this function is on average O(n), where n is the length of the input array. This is because the lookup and addition operations in the hash set have a constant average time complexity. However, in the worst case scenario (all elements are duplicates), the time complexity can be O(n^2) due to potential hash collisions in the set.

### Space Complexity

The space complexity of this function is O(n) in the worst case scenario. This is because the `HashSet` can grow up to n elements in size if all elements in the array are unique. However, in cases with fewer unique elements, the space complexity will be lower.


### Related Problems

* Contains Duplicate [https://leetcode.com/problems/contains-duplicate/]