
# 01 Introduction to C# and Data Types

## Understanding Data Types

**Test your Knowledge**

What type would you choose for the following numbers?

- A person’s telephone number -> `string`
- A person’s height -> `float`
- A person’s age -> `int`
- A person’s gender (Male, Female, Prefer Not To Answer) -> `enum`
- A person’s salary -> `int`
- A book’s ISBN -> `string`
- A book’s price -> `float`
- A book’s shipping weight -> `float`
- A country’s population -> `int`
- The number of stars in the universe -> `int`
- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) -> `int`

### What are the differences between value type and reference type variables? What is boxing and unboxing?

**Value Type:**

- Directly contain their data
- Each has its own copy of data
- Operation on one cannot affect another

**Reference Type:**

- Store references to their data (known as objects)
- Two reference variables can reference the same object
- Operation on one can affect another

**Boxing:**

- Boxing is the process of converting a value type (such as an int, double, char, etc.) to a reference type (object).

**Unboxing:**

- Unboxing is the reverse process of converting an object back to a value type. When you unbox an object, you extract the value type from the object.

### What is meant by the terms managed resource and unmanaged resource in .NET?

**Managed Resource:**

- These are resources managed by the .NET runtime (CLR), such as objects created in .NET languages (e.g., arrays, strings). The CLR handles their memory management automatically.

**Unmanaged Resource:**

- These are resources not managed by the CLR, such as file handles, database connections, and memory allocated via the Windows API. Developers must manually release these resources to avoid leaks, often using the IDisposable interface.

### What's the purpose of Garbage Collector in .NET?

- The garbage collector (GC) in .NET automatically manages memory allocation and deallocation, reclaiming memory from objects that are no longer in use. This helps prevent memory leaks, optimizes memory usage, and improves application performance by reducing manual memory management overhead.

## Controlling Flow and Converting Types

### What happens when you divide an int variable by 0?

- Dividing an int variable by 0 throws a `System.DivideByZeroException` at runtime.

### What happens when you divide a double variable by 0?

- Dividing a double variable by 0 results in `Infinity` if positive or negative, and `NaN` (Not a Number) if the dividend is also 0.

### What happens when you overflow an int variable, that is, set it to a value beyond its range?

- Overflowing an int variable causes it to wrap around to the minimum value if not checked, or throws an `OverflowException` if checked using the `checked` keyword.

### What is the difference between `x = y++;` and `x = ++y;`?

- `x = y++;` assigns y to x and then increments y.
- `x = ++y;` increments y first and then assigns the incremented value to x.

### What is the difference between `break`, `continue`, and `return` when used inside a loop statement?

- `break` exits the loop entirely.
- `continue` skips the current iteration and proceeds to the next iteration of the loop.
- `return` exits the loop and the enclosing method, returning a value if specified.

### What are the three parts of a `for` statement and which of them are required?

- The three parts are initialization, condition, and iteration. None of these parts are required; a for loop can compile with empty parts (e.g., `for ( ; ; )`).

### What is the difference between the `=` and `==` operators?

- `=` is the assignment operator, which assigns a value to a variable.
- `==` is the equality operator, which checks if two values are equal.

### Does the following statement compile? `for ( ; true; ) ;`

- Yes, it compiles. It creates an infinite loop with no initialization, condition, or iteration statements.

### What does the underscore `_` represent in a switch expression?

- The underscore `_` is the discard pattern in a switch expression, acting as a default case that matches any value not previously matched.

### What interface must an object implement to be enumerated over by using the `foreach` statement?

- An object must implement the `IEnumerable` or `IEnumerable<T>` interface to be enumerated over by the `foreach` statement.

---

This formatting should make the content more readable and structured.


Here's the properly formatted Markdown version of your questions and answers related to arrays and strings in C#:

---

# 02 Arrays and Strings

## Test your Knowledge

### 1. When to use String vs. StringBuilder in C#?

- Use `String` when you need immutable strings, meaning the string value does not change after it is created. This is suitable for small string manipulations.
- Use `StringBuilder` for mutable strings, where you need to perform a large number of modifications (append, remove, insert) to the string, as it is more efficient for such operations.

### 2. What is the base class for all arrays in C#?

- The base class for all arrays in C# is `System.Array`.

### 3. How do you sort an array in C#?

- You can sort an array in C# using the `Array.Sort()` method. For example:
  ```csharp
  int[] numbers = { 5, 2, 8, 3, 9 };
  Array.Sort(numbers);
  ```

### 4. What property of an array object can be used to get the total number of elements in an array?

- The `Length` property of an array object can be used to get the total number of elements in an array.
  ```csharp
  int[] numbers = { 5, 2, 8, 3, 9 };
  int totalElements = numbers.Length; // totalElements will be 5
  ```

### 5. Can you store multiple data types in System.Array?

- No, `System.Array` is a collection of elements of the same type. To store multiple data types, you can use collections like `ArrayList` or `List<object>`.

### 6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

- `System.Array.CopyTo()`: Copies the elements of one array to another existing array starting at the specified index of the target array.
  ```csharp
  int[] sourceArray = { 1, 2, 3 };
  int[] targetArray = new int[3];
  sourceArray.CopyTo(targetArray, 0);
  ```

- `System.Array.Clone()`: Creates a shallow copy of the array. The returned array has the same size and elements as the original array.
  ```csharp
  int[] sourceArray = { 1, 2, 3 };
  int[] clonedArray = (int[])sourceArray.Clone();
  ```

---

This formatting should make the content clear and easy to understand.
