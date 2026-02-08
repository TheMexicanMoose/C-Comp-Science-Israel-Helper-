
# **NodeLib Functions Explaining**

In here I will explain all the functions of NodeLib and how to use it.



## Implementation In Code

In the code, make sure you have these 2 lines so you can use the functions:



```csharp

using Unit4.CollectionsLib;

using TestLib.NodeLib;

```



Make sure before every function you write `NodeLib.`



You can also initialize the library as followed to not have to write this:



```csharp

using static TestLib.NodeLib.NodeLib;

```



---



## `Get_By_Index_Node`

Retrieve an element from a linked list by its **index**. Use `-1` to get the **last element**. The original linked list remains intact.



### **Syntax**

```csharp

Get_By_Index_Node<T>(Node<T> chain, int index)

```



#### Parameters:



- `chain` → The head of the linked list to retrieve the element from (`Node<T>`).

- `index` → The index of the element. Use `-1` to get the last element.



#### Returns:



- Element at the specified index if it exists.

- `default(T)` if the index is out of bounds.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



// Get element at index 1

int value = NodeLib.Get_By_Index_Node(list, 1); // 20



// Get last element

int last = NodeLib.Get_By_Index_Node(list, -1); // 30

```



---



## `Set_By_Index_Node`

Replaces an element in a linked list by its **index**. Use `-1` to replace the **last element**.

If the index does not exist, the list remains **unchanged**.



### **Syntax**

```csharp

Set_By_Index_Node<T>(Node<T> chain, int index, T newValue)

```



#### Parameters:



- `chain` → The head of the linked list in which the element will be replaced (`Node<T>`).

- `index` → The index of the element to replace. Use `-1` to replace the last element.

- `newValue` → The new value to insert at the given index.



#### Returns:



- This function does not return a value.

- If the index is out of bounds, no changes are made.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



// Replace element at index 1

NodeLib.Set_By_Index_Node(list, 1, 99);

// List now contains: 10 → 99 → 30



// Replace last element

NodeLib.Set_By_Index_Node(list, -1, 50);

// List now contains: 10 → 99 → 50

```



---



## `Insert_To_Index_Node`

Inserts a value into a linked list at a **specific index**.

If the index is `-1`, the value is inserted at the **end of the list**.



### **Syntax**

```csharp

Insert_To_Index_Node<T>(Node<T> chain, int index, T newValue)

```



#### Parameters:



- `chain` → The head of the linked list to insert the value into (`Node<T>`).

- `index` → The index at which to insert the new value. Use `-1` to insert at the end.

- `newValue` → The value to insert into the list.



#### Returns:



- This function does not return a value.

- If the index is out of bounds, no changes are made.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



// Insert at index 1

NodeLib.Insert_To_Index_Node(list, 1, 99);

// List now contains: 10 → 99 → 20 → 30



// Insert at the end

NodeLib.Insert_To_Index_Node(list, -1, 50);

// List now contains: 10 → 99 → 20 → 30 → 50

```



---



## `CreateList`

Creates a **linked list** from an array of integers.

Returns the **head** of the newly created linked list.



### **Syntax**

```csharp

CreateList(params int[] values)

```



#### Parameters:



- `values` → Variable number of integers to be added to the linked list.



#### Returns:



- The head node (`Node<int>`) of the newly created linked list.

- Returns `null` if no values are provided.



#### Complexity:



- **O(n)** – iterates through the array once.



#### Example:



```csharp

// Create a linked list with values 10, 20, 30

Node<int> list = NodeLib.CreateList(10, 20, 30);

// List contains: 10 → 20 → 30



// Create from individual parameters

Node<int> list2 = NodeLib.CreateList(5, 15, 25, 35);

// List contains: 5 → 15 → 25 → 35

```



---



## `PrintList`

Prints all elements of a linked list to the console.

Each element is separated by a space.



### **Syntax**

```csharp

PrintList<T>(Node<T>? q)

```



#### Parameters:



- `q` → The head of the linked list to print (`Node<T>`).



#### Returns:



- This function does not return a value.

- Prints the values to the console.

- Prints "רשימה ריקה" (empty list) if the list is `null`.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



// Print the list

NodeLib.PrintList(list);

// Output: 10 20 30



// Print empty list

NodeLib.PrintList<int>(null);

// Output: רשימה ריקה

```



---



## `LengthLst`

Returns the **number of elements** in a linked list.



### **Syntax**

```csharp

LengthLst<T>(Node<T> q)

```



#### Parameters:



- `q` → The head of the linked list (`Node<T>`).



#### Returns:



- The number of elements in the linked list (int).



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



// Get the length of the list

int length = NodeLib.LengthLst(list); // 3



// Empty list

Node<int> empty = null;

int emptyLength = NodeLib.LengthLst(empty); // 0

```



---



## `Revers`

Reverses the direction of a linked list.

Returns the **new head** of the reversed list.



### **Syntax**

```csharp

Revers<T>(Node<T> root)

```



#### Parameters:



- `root` → The head of the linked list to reverse (`Node<T>`).



#### Returns:



- The new head node of the reversed linked list.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);

// Original list: 10 → 20 → 30



// Reverse the list

Node<int> reversed = NodeLib.Revers(list);

// Reversed list: 30 → 20 → 10

```



---



## `IsExistNode`

Checks whether a **value exists in a linked list**.

The original linked list remains **unchanged**.



### **Syntax**

```csharp

IsExistNode<T>(Node<T> head, T value)

```



#### Parameters:



- `head` → The head of the linked list to search in (`Node<T>`).

- `value` → The value to search for in the linked list.



#### Returns:



- `true` if the value exists in the linked list.

- `false` if the value does not exist.



#### Complexity:



- **O(n)** – iterates through the linked list once.



#### Example:



```csharp

Node<int> list = NodeLib.CreateList(10, 20, 30);



bool exists = NodeLib.IsExistNode(list, 20); // true

bool notExists = NodeLib.IsExistNode(list, 99); // false

```



---



## `IsEqualLists`

Checks whether **two linked lists are identical** in both **size and order**.

Returns `false` if the number of elements or their order differs.



### **Syntax**

```csharp

IsEqualLists<T>(Node<T> head1, Node<T> head2)

```



#### Parameters:



- `head1` → The head of the first linked list to compare (`Node<T>`).

- `head2` → The head of the second linked list to compare (`Node<T>`).



#### Returns:



- `true` if both linked lists contain the same elements in the same order.

- `false` if the lists differ in size or order.



#### Complexity:



- **O(n)** – iterates through both linked lists once.



#### Example:



```csharp

Node<int> list1 = NodeLib.CreateList(10, 20, 30);

Node<int> list2 = NodeLib.CreateList(10, 20, 30);

Node<int> list3 = NodeLib.CreateList(10, 30, 20);



bool same1 = NodeLib.IsEqualLists(list1, list2); // true

bool same2 = NodeLib.IsEqualLists(list1, list3); // false

```



