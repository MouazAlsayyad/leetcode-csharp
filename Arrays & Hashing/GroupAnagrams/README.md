## GroupAnagrams (C#)

This code implements a function named `GroupAnagrams` that groups anagrams together in an array of string lists.

### Anagram Definition

An anagram is a word or phrase formed by rearranging the letters of another word or phrase. The letters in an anagrams appear in the same frequency but in a different order.

### Function Description

The `GroupAnagrams` function takes an array of strings, `strs`, as input and returns a new list where each sub-list contains strings that are anagrams of each other.

### Implementation

1. **Dictionary for Anagram Groups:** The function utilizes a dictionary, `anagramMap`, to store groups of anagrams. The key in the dictionary is a unique identifier for a group of anagrams, and the value is a list of strings belonging to that group.

2. **Character Count Array:** Inside the loop iterating through each string (`str`), an integer array `count` of size 26 is created. This array acts as a histogram to store the frequency of each lowercase letter (a-z) in the current string.

3. **Character Frequency Counting:** The function iterates through each character (`c`) in the current string:
    - It subtracts 'a' from the character's ASCII value to get its index within the `count` array (assuming lowercase letters only). This allows direct access to the corresponding frequency count for that letter.
    - The count at that index in the `count` array is incremented, signifying one more occurrence of that letter in the string.

4. **Creating Unique Key:** After counting character frequencies, a string `key` is constructed by joining all the elements in the `count` array separated by a delimiter (e.g., "#"). This string acts as a unique identifier for the anagram group based on the letter frequencies.

5. **Grouping Anagrams:** 
    - The function checks if the `anagramMap` already contains a key matching the constructed `key`. 
        - If the key doesn't exist, a new list is created and added to the `anagramMap` with the `key` as the identifier.
    - Regardless of whether the key exists, the current string (`str`) is appended to the list associated with the `key` in the `anagramMap`. This effectively groups anagrams together in the list.

6. **Returning Groups:** Finally, the function returns a list containing all the values (anagram lists) from the `anagramMap`. The `[..` syntax (assuming C# 7 or later) creates a new list from the existing collection in `anagramMap.Values`.

### Time Complexity

The time complexity of this function is O(nk), where n is the number of strings in the input array and k is the average length of a string. This is because the character counting and key creation happen for each character in each string (nk), and these operations are considered constant time for fixed-size arrays and strings.

### Space Complexity

The space complexity of this function is O(nk) in the worst case. This is because the `anagramMap` can potentially store n lists, each containing up to k strings in the worst case (all strings are unique anagrams). However, in cases with fewer unique anagram groups, the space complexity will be lower.



### Related Problems

* 49. Group Anagrams [https://leetcode.com/problems/group-anagrams/]
