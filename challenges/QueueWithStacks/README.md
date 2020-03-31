# **Queue with Stack**

**Author: Jin Kim**

---

### Problem Domain

Create a class called `PseudoQueue` that has two stack objects when instated and create a method called `Enqueue` and `Dequeue` that utilize `Push`, `Pop`, and `Peak` methods from `Stack` class.

---

### Inputs and Expected Outputs

#### Stack
*Starting stack Top - 5*  

|Method | Input | Expected Output |
| :--------- | :----------- | :----------- |
| Push | 4 |  Top - 4 - 5 |
| Pop | N/A | Top - 5 |
| Peek | N/A | "5" |
| IsEmpty | N/A | false |

### Queue
*Starting stack Rear - 5 - Front*  

|Method | Input | Expected Output |
| :--------- | :----------- | :----------- |
| Enqueue | 4 |  Rear - 5 - 4 - Front |
| Dequeue | N/A | Rear - 5 - Front |
| Peek | N/A | "5" |
| IsEmpty | N/A | false |


---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(1) | O(1) |


---


### Whiteboard Visual
![White Board](../../assets/StackNQueue/whiteboards.png)


---

### Screen Shot
---
![Application Demo](../../assets/StackNQueue/application-running.png)
Screenshot of functional application

![Unit Testing](../../assets/StackNQueue/unit-test.png)
Screenshot of unit testing passed

---
### Change Log
- 1.2 - Created unit test that passes
- 1.1 - Added classes, `Stack` and `Queue`, to the application and finished methods.
- 1.0 - Set a folder for `Stack and Queue` challenge in the challenges folder.

