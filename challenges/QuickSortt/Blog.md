# **Quick Sort**

**Author: Jin Kim**

*Co-author: Allyson Reyes*

---

### Definition

`Quick sort` method is a way of sorting algorithm that first picks `pivot` and using that pivot determine where `low`, tracker` 

---

### Pseudo Code

```cs
ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```

---


### Blog Article
Input `[8,4,3,42,16,15]`
 
![Blog](../../assets/QuickSort/trace.png)

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

