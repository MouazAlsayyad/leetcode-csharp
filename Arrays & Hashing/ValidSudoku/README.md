## Validating Sudoku Boards in C#

This code implements a function named `IsValidSudoku` that determines if a given Sudoku board is valid according to the standard Sudoku rules:

* Each row must contain the digits 1-9 without repetition.
* Each column must contain the digits 1-9 without repetition.
* Each of the nine 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.

**Function Breakdown:**

1. **`IsValidSudoku` Function:**
   - Takes a 2D character array `board` representing the Sudoku board.
   - Returns `true` if the board is valid, `false` otherwise.

2. **Grid Size:**
   - `n` is defined as the size of the Sudoku board (typically 9).

3. **Row Validation:**
   - Iterates through each row (`i`) using a `HashSet` named `rowSet` to track unique characters.
   - For each element (`j`) in the row:
     - Checks if it's a dot (`.`) and skips if so.
     - If a valid character (1-9):
       - Tries adding it to `rowSet`.
       - If addition fails (character already exists), the board is invalid (returns `false`).

4. **Column Validation:**
   - Performs similar validation for each column (`j`) using a `colSet` for unique characters.

5. **Sub-Box Validation:**
   - Iterates through each 3x3 sub-box using nested loops (`k` and `l`).
   - Uses a `subBoxSet` to track unique characters in the current sub-box.
   - Similar validation logic as row and column checks for duplicates within the sub-box.

6. **Return Result:**
   - If all checks pass, the board is valid (returns `true`).
   - If any duplicates are found, the board is invalid (returns `false`).

**Efficiency:**

- Uses `HashSet` for efficient duplicate character checks in rows, columns, and sub-boxes.
- Avoids creating multiple arrays for storing characters, improving memory usage.

### Related Problems

* 36. Valid Sudoku [https://leetcode.com/problems/valid-sudoku/] (LeetCode)