# **Merge Sort**

**Author: Jin Kim**

*Co-author: Allyson Reyes*

---

### Definition

`Merge sort` method is taking the two side of the array and partial it until left and right has one number each. As call stack pop off, it will continually sort until array is fully sorted.

---

### Pseudo Code

```cs

ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```

---


### Blog Article
Input `[8,4,3,42,16,15]`
 
![Blog](../../assets/MergeSort/whiteboard.png)

Pass 1 ~ 3: This is call stacking on top inside of `MergeSort` method where array is partialing to the left and right until right side has one left and one right.  
Pass 4 ~ 5: This is in `Merge` method, where it is being sorted and using `k` for array, `i` for left array, `j` for right array counter.   
Pass 6 ~ 8: Top stack pop off and array will go through `Merge` method to sort out. After its sorted it will pop off from call stack.  
Pass 9: After right side of the array will go top of the stack and partial it to left and right and since right side length is more than 1 it will partial one more time.  
Pass 10 - 11: Adding into the call stack, `[16,15]` will be used for `Merge` method, which then sort itself out.  
Pass 12 - 14: Then the right side enters the `Merge` method, which will sort its array then pop off the call stack.  
Pass 15+: Entire array with left and right arrays will enter `Merge` Method, however, since it is been sorted, it will go through the method without any sorting.



---

### Screen Shot
---
![Application Demo](../../assets/MergeSort/Application.png)
Screenshot of application running

![Unit Test](../../assets/MergeSort/unittest.png)
Unit test passing

---

### Efficiency

- Time: O(n log n)
  - This is because there are more loop as the recursion occurs.

- Space: 0(n)
  - This is because we only create array to store left and right and will be used continuously throughout the recursion.


---
### Change Log
- 1.2 - Completed README Files.   
- 1.1 - Created `MergeSort` and works in application.
- 1.0 - Created a repository and initialized repository.

