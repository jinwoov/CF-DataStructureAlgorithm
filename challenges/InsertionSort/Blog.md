# **Insertion Sort**

**Author: Jin Kim**

*Co-author: Allyson Reyes*

---

### Definition

Insertion sort is a method that holds the current iteration element using `temp` variable and sort through the array in backward order until temp seems fit.

---

### Pseudo Code

```cs
  InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp

    return arr
```

---


### Blog Article
Sample of [8,4,23,42,16,15]
 
![Blog](../../assets/InsertionSort/Whiteboard.png)



---

### Screen Shot
---
![Application Demo](../../assets/InsertionSort/Application.png)
Screenshot of application running

---

### Efficiency

- Time: O(n^2)
  - This is because there is nested while loop inside of for loop, which up the time by `O` of `n` `square`

- Space: 0(1)
  - This is because there ins't any array or list that is added to the heap and nothing has been declare or instantiated that will take the space, making the space constant of 1.


---
### Change Log
- 1.2 - Completed README Files.   
- 1.1 - Created `InsertionSort` and works in application.
- 1.0 - Created a repository and initialized repository.

