{\rtf1\ansi\ansicpg1252\cocoartf2761
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica-Bold;\f1\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue0;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c0;}
\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\sa213\partightenfactor0

\f0\b\fs32 \cf0 \expnd0\expndtw0\kerning0
01 Introduction to C# and Data Types
\f1\b0 \
Understanding Data Types\
Test your Knowledge\
1. What type would you choose for the following \'93numbers\'94?\
A person\'92s telephone number -> string\
A person\'92s height -> float\
A person\'92s age -> int\
A person\'92s gender (Male, Female, Prefer Not To Answer) -> enum\
A person\'92s salary -> int\
A book\'92s ISBN -> string\
A book\'92s price -> float\
A book\'92s shipping weight -> float\
A country\'92s population -> int\
The number of stars in the universe -> int\
The number of employees in each of the small or medium businesses in the\
United Kingdom (up to about 50,000 employees per business) -> int\
\'a0\
2. What are the difference between value type and reference type variables? What is\
boxing and unboxing?\
Value Type:\
Directly contain their data\
Each has its own copy of data\
Operation on one can not effect another\
Reference Type:\
Store references to their data (known as objects)\
Two reference variables can reference the same project\
Operation on one can effect another\
Boxing\
Boxing is the process of converting a value type (such as an int, double, char, etc.) to a reference type (object).\
Unboxing is the reverse process of converting an object back to a value type. When you unbox an object, you extract the value type from the object.\
3. What is meant by the terms managed resource and unmanaged resource in .NET\
Managed Resource:\
These are resources managed by the .NET runtime (CLR), such as objects created in .NET languages (e.g., arrays, strings). The CLR handles their memory management automatically.\
Unmanaged Resource:\
These are resources not managed by the CLR, such as file handles, database connections, and memory allocated via the Windows API. Developers must manually release these resources to avoid leaks, often using the IDisposable interface.\
4. Whats the purpose of Garbage Collector in .NET?\
The garbage collector (GC) in .NET automatically manages memory allocation and deallocation, reclaiming memory from objects that are no longer in use. This helps prevent memory leaks, optimizes memory usage, and improves application performance by reducing manual memory management overhead.\
\
\pard\pardeftab720\sa213\partightenfactor0

\f0\b\fs37\fsmilli18667 \cf0 Controlling Flow and Converting Types
\f1\b0\fs32 \

\f0\b \
1. **What happens when you divide an int variable by 0?**\
  
\f1\b0 Dividing an `int` variable by 0 throws a `System.DivideByZeroException` at runtime.
\f0\b \
\
2. **What happens when you divide a double variable by 0?**\

\f1\b0    Dividing a `double` variable by 0 results in `Infinity` if positive or negative, and `NaN` (Not a Number) if the dividend is also 0.
\f0\b \
\
3. **What happens when you overflow an int variable, that is, set it to a value beyond its range?**\

\f1\b0     Overflowing an `int` variable causes it to wrap around to the minimum value if not checked, or throws an `OverflowException` if checked using the `checked` keyword.
\f0\b \
\
4. **What is the difference between x = y++; and x = ++y?**\
  
\f1\b0  - `x = y++;` assigns `y` to `x` and then increments `y`.\
   - `x = ++y;` increments `y` first and then assigns the incremented value to `x`.
\f0\b \
\
5. **What is the difference between break, continue, and return when used inside a loop statement?**\
   
\f1\b0 - `break` exits the loop entirely.\
   - `continue` skips the current iteration and proceeds to the next iteration of the loop.\
   - `return` exits the loop and the enclosing method, returning a value if specified.
\f0\b \
\
6. **What are the three parts of a for statement and which of them are required?**\
  
\f1\b0  - The three parts are initialization, condition, and iteration. None of these parts are required; a for loop can compile with empty parts (e.g., `for ( ; ; )`).
\f0\b \
\
7. **What is the difference between the = and == operators?**\
 
\f1\b0   - `=` is the assignment operator, which assigns a value to a variable.\
   - `==` is the equality operator, which checks if two values are equal.
\f0\b \
\
8. **Does the following statement compile? `for ( ; true; ) ;`**\

\f1\b0     Yes, it compiles. It creates an infinite loop with no initialization, condition, or iteration statements.
\f0\b \
\
9. **What does the underscore _ represent in a switch expression?**\

\f1\b0    The underscore `_` is the discard pattern in a switch expression, acting as a default case that matches any value not previously matched.
\f0\b \
\
10. **What interface must an object implement to be enumerated over by using the foreach statement?**\

\f1\b0      An object must implement the `IEnumerable` or `IEnumerable<T>` interface to be enumerated over by the `foreach` statement.\
\pard\pardeftab720\sa213\partightenfactor0
\cf0 \
}