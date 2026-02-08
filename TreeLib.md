# **TreeLib Functions Explaining**
in here I will explain all the functions in of TreeLib and how
to use it

## Implementation In Code
in the code, make sure you have these 2 lines so you can
use the functions

```csharp
using Unit4.CollectionsLib;
using TestLib.TreeLib;
```

make sure before every function you write
`TreeLib.`

you can also initialise the library as followed to not
have to write this

```csharp
using static TestLib.TreeLib.TreeLib;
```


## `CreateTree`
Creates a **binary tree** from an array in level-order (breadth-first) sequence. The array is interpreted as a complete binary tree where index `i` has left child at `2*i + 1` and right child at `2*i + 2`.

### **Syntax**
```csharp
CreateTree<T>(T[] arr, int index = 0)
```

#### parameters:

- `arr` → The array to convert into a binary tree (`T[]`).

- `index` → The starting index in the array (default is `0`).

#### Returns:

- The root node of the binary tree (`BinNode<T>`).
- `null` if the index is out of bounds.

#### Complexity:

- **O(n)** – creates nodes for all elements in the array.

#### Example:

```csharp
int[] arr = { 10, 20, 30, 40, 50 };

// Create binary tree from array
BinNode<int> root = TreeLib.CreateTree(arr);

// Tree structure:
//       10
//      /  \
//    20    30
//   /  \
//  40  50
```


## `Scan1`
Performs a **pre-order traversal** (Node-Left-Right) on the binary tree.  
Executes an action on each node in the following order: current node, left subtree, right subtree.

### **Syntax**
```csharp
Scan1<T>(BinNode<T> root, Action<T> action)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).
- `action` → The action to perform on each node's value.

#### Returns:

- This function does not return a value.
- The action is executed on all nodes in pre-order.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:

```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

// Print all values in pre-order
TreeLib.Scan1(root, value => Console.Write(value + " "));
// Output: 10 20 40 50 30
```


## `Scan2`
Performs an **in-order traversal** (Left-Node-Right) on the binary tree.  
Executes an action on each node in the following order: left subtree, current node, right subtree.

### **Syntax**
```csharp
Scan2<T>(BinNode<T> root, Action<T> action)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).
- `action` → The action to perform on each node's value.

#### Returns:

- This function does not return a value.
- The action is executed on all nodes in in-order.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

// Print all values in in-order
TreeLib.Scan2(root, value => Console.Write(value + " "));
// Output: 40 20 50 10 30
```


## `Scan3`
Performs a **post-order traversal** (Left-Right-Node) on the binary tree.  
Executes an action on each node in the following order: left subtree, right subtree, current node.

### **Syntax**
```csharp
Scan3<T>(BinNode<T> root, Action<T> action)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).
- `action` → The action to perform on each node's value.

#### Returns:

- This function does not return a value.
- The action is executed on all nodes in post-order.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

// Print all values in post-order
TreeLib.Scan3(root, value => Console.Write(value + " "));
// Output: 40 50 20 30 10
```


## `LengthBt`
Returns the **total number of nodes** in a binary tree.

### **Syntax**
```csharp
LengthBt<T>(BinNode<T> root)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).

#### Returns:

- The number of nodes in the tree (`int`).
- Returns `0` if the tree is empty.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

int count = TreeLib.LengthBt(root); // 5
```


## `SumBt`
Returns the **sum of all values** in a binary tree of integers.

### **Syntax**
```csharp
SumBt(BinNode<int> root)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<int>`).

#### Returns:

- The sum of all node values (`int`).
- Returns `0` if the tree is empty.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

int sum = TreeLib.SumBt(root); // 150
```


## `IsExistBt`
Checks whether a **value exists** in the binary tree.  
The tree remains **unchanged**.

### **Syntax**
```csharp
IsExistBt<T>(BinNode<T> root, T value)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).
- `value` → The value to search for in the tree.

#### Returns:

- `true` if the value exists in the tree.
- `false` if the value does not exist.

#### Complexity:

- **O(n)** – may visit all nodes in worst case.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

bool exists = TreeLib.IsExistBt(root, 30); // true
bool notExists = TreeLib.IsExistBt(root, 99); // false
```


## `IsEqualBTs`
Checks whether **two binary trees are identical** in both **structure and values**.  
Returns `false` if the trees differ in structure or node values.

### **Syntax**
```csharp
IsEqualBTs<T>(BinNode<T> root1, BinNode<T> root2)
```
#### parameters:

- `root1` → The root of the first binary tree (`BinNode<T>`).
- `root2` → The root of the second binary tree (`BinNode<T>`).

#### Returns:

- `true` if both trees have the same structure and values.
- `false` if the trees differ in structure or values.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr1 = { 10, 20, 30 };
int[] arr2 = { 10, 20, 30 };
int[] arr3 = { 10, 30, 20 };

BinNode<int> tree1 = TreeLib.CreateTree(arr1);
BinNode<int> tree2 = TreeLib.CreateTree(arr2);
BinNode<int> tree3 = TreeLib.CreateTree(arr3);

bool same1 = TreeLib.IsEqualBTs(tree1, tree2); // true
bool same2 = TreeLib.IsEqualBTs(tree1, tree3); // false
```


## `Height`
Returns the **height** of the binary tree (number of levels).  
A single-node tree has height `0`, an empty tree has height `-1`.

### **Syntax**
```csharp
Height<T>(BinNode<T> root)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).

#### Returns:

- The height of the tree (`int`).
- Returns `-1` if the tree is empty.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

// Tree structure:
//       10       <- level 0
//      /  \
//    20    30    <- level 1
//   /  \
//  40  50        <- level 2

int height = TreeLib.Height(root); // 2
```


## `CountLeaves`
Counts the number of **leaf nodes** (nodes with no children) in the binary tree.

### **Syntax**
```csharp
CountLeaves<T>(BinNode<T> root)
```
#### parameters:

- `root` → The root of the binary tree (`BinNode<T>`).

#### Returns:

- The number of leaf nodes in the tree (`int`).
- Returns `0` if the tree is empty.

#### Complexity:

- **O(n)** – visits each node once.

#### Example:
```csharp
int[] arr = { 10, 20, 30, 40, 50 };
BinNode<int> root = TreeLib.CreateTree(arr);

// Tree structure:
//       10
//      /  \
//    20    30  <- leaf
//   /  \
//  40  50      <- leaves

int leaves = TreeLib.CountLeaves(root); // 3 (nodes 30, 40, 50)
```