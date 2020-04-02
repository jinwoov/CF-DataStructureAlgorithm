# **Multi Bracket Validation**

**Author: Jin Kim**

---

### Problem Domain

Write a method `MultiBracketValidation` that takes in a string and see if the bracket has matching bracket. If the bracket is missing a pair, return false, otherwise it all of the bracket in the string has a pair, return true.

---

### Inputs and Expected Outputs

| Input(List1) | Input2(List2) |Expected Output |
| :----------- |:--------- | :----------- |
| head -> [1] -> [3] -> [2] -> X| head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> [4] -> X |
|head -> [1] -> [3] -> X| head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [4] -> X |
|head -> [1] -> [3] -> [2] -> X|head -> [5] -> [9] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> X |

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(1) |


---


### Whiteboard Visual
![LLMerged](../../assets/LLmerged.png)


---

### Screen Shot
---
![Application Demo](../../assets/LLMerged/applicaiton-running.png)
Screenshot of application running

![Unit Testing](../../assets/LLMerged/unit-testing-pass.png)
Screenshot of unit testing passed

---
### Change Log
- 1.4 - Completed README Files.  
- 1.3 - Unit testing implemented and passed.
- 1.2 - Repository error, recreated the methods and added the refactored the MergedLists method to a new class. 
- 1.1 - Created `MergedLists` and works in application.
- 1.0 - Created a repository and copied classes from Link list.

