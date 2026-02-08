# **QueueLib Functions Explaining**
in here I will explain all the functions in of queueLib and how 
to use it

## Implementation In Code
in the code, make sure you have these 2 lines so you can
use the functions

```csharp
using Unit4.collectionLib;
using TestLib.QueueLib;
````

make sure before every function you write
`QueueLib.`

you can also initialise the library as followed to not 
have to write this

```csharp
using static TestLib.QueueLib.QueueLib;
````


## Get_By_Index_Queue
Retrieve an element from a queue by its **index**. Use `-1` to get the **last element**. The original queue remains intact.

### **Syntax**
```csharp
Get_By_Index_Queue<T>(Queue<T> q, int index)
````

#### parameters:

- `q` → The queue to retrieve the element from (`Queue<T>`).

- `index` → The index of the element. Use `-1` to get the last element.

#### Returns:

- Element at the specified index if it exists

- `default(T)` if the index is out of bounds (except `-1`).

- Throws `InvalidOperationException` if the queue is empty.

#### Complexity:

- **O(n)** – iterates through the queue once.

#### Example:

```csharp
var queue = new Queue<int>();
queue.Insert(10);
queue.Insert(20);
queue.Insert(30);

// Get element at index 1
int value = QueueLib.Get_By_Index_Queue(queue, 1); // 20

// Get last element
int last = QueueLib.Get_By_Index_Queue(queue, -1); // 30
````

## Set_By_Index_Queue
Replaces an element in a queue by its **index**.  
If the index does not exist, the queue remains **unchanged**.

### **Syntax**
```csharp
Set_By_Index_Queue<T>(Queue<T> q, int index, T newValue)
````
#### parameters:

- `q` → The queue in which the element will be replaced (`Queue<T>`).
- `index` → The index of the element to replace.
- `newValue` → The new value to insert at the given index.

#### Returns:

- This function does not return a value.
- If the queue is empty or the index is out of bounds, no changes are made.

#### Complexity:

- **O(n)** – iterates through the queue once.

#### Example:

```csharp
var queue = new Queue<int>();
queue.Insert(10);
queue.Insert(20);
queue.Insert(30);

// Replace element at index 1
QueueLib.Set_By_Index_Queue(queue, 1, 99);

// Queue now contains: 10, 99, 30

```