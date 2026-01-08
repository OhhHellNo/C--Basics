# C# Fundamentals Documentation

A comprehensive guide to understanding the core concepts of C# and .NET architecture.

## Table of Contents

- [Overview](#overview)
- [Common Language Runtime (CLR)](#common-language-runtime-clr)
- [.NET Application Architecture](#net-application-architecture)
- [Core Concepts](#core-concepts)
  - [Class](#class)
  - [Namespace](#namespace)
- [Data Types](#data-types)
  - [Value Types](#value-types)
  - [Reference Types](#reference-types)
- [Type Conversion](#type-conversion)
  - [Implicit Conversion](#implicit-conversion)
  - [Explicit Conversion (Casting)](#explicit-conversion-casting)
  - [Conversion Methods](#conversion-methods)
- [Operators](#operators)
  - [Arithmetic Operators](#arithmetic-operators)
  - [Comparison Operators](#comparison-operators)
  - [Logical Operators](#logical-operators)
  - [Assignment Operators](#assignment-operators)
  - [Increment/Decrement Operators](#incrementdecrement-operators)
- [Control Flow](#control-flow)
  - [Conditional Statements](#conditional-statements)
  - [Loops](#loops)
  - [Jump Statements](#jump-statements)
- [Getting Started](#getting-started)
- [Resources](#resources)

---

## Overview

This documentation provides an introduction to the fundamental concepts of C# programming and the .NET framework architecture. It covers the compilation process, application structure, and essential building blocks.

---

## Common Language Runtime (CLR)

The Common Language Runtime serves as the execution environment for .NET applications. 

### Compilation Process

The CLR follows a multi-stage compilation process:

1. **Source Code** → C# source code is written by developers
2. **Intermediate Language (IL)** → The compiler translates source code into platform-independent IL code
3. **Native Code** → The Just-In-Time (JIT) compiler converts IL code to machine-specific native code at runtime

This approach enables platform independence and optimized performance.

---

## .NET Application Architecture

.NET applications are constructed using a modular architecture consisting of fundamental building blocks called **classes**.

---

## Core Concepts

### Class

A class is a structural container that encapsulates two primary components:

#### Components

1. **Data (Attributes)**
   - Variables and properties that store the state of an object
   - Represents the characteristics of the class

2. **Methods (Functions)**
   - Executable code blocks that define behavior and operations
   - Implements the functionality of the class

#### Example

```csharp
public class Person
{
    // Data/Attributes
    public string Name { get; set; }
    public int Age { get; set; }
    
    // Methods/Functions
    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {Name} and I'm {Age} years old.");
    }
}
```

### Namespace

As applications scale and the number of classes increases, organization becomes essential. A **namespace** provides a hierarchical organizational structure for grouping related classes together.

#### Purpose

- **Logical Grouping** - Groups related classes together
- **Code Organization** - Improves maintainability and readability
- **Naming Collision Prevention** - Avoids conflicts between classes with similar names

#### Example

```csharp
namespace MyApplication.Models
{
    public class User
    {
        // Class implementation
    }
}

namespace MyApplication.Services
{
    public class UserService
    {
        // Class implementation
    }
}
```

---

## Data Types

C# is a strongly-typed language, meaning every variable must have a declared type. Data types are categorized into two main groups:

### Value Types

Value types store data directly and are allocated on the stack. They include:

#### Integral Types

| Type | Size | Range | Description |
|------|------|-------|-------------|
| `byte` | 8-bit | 0 to 255 | Unsigned integer |
| `sbyte` | 8-bit | -128 to 127 | Signed integer |
| `short` | 16-bit | -32,768 to 32,767 | Signed integer |
| `ushort` | 16-bit | 0 to 65,535 | Unsigned integer |
| `int` | 32-bit | -2,147,483,648 to 2,147,483,647 | Signed integer |
| `uint` | 32-bit | 0 to 4,294,967,295 | Unsigned integer |
| `long` | 64-bit | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | Signed integer |
| `ulong` | 64-bit | 0 to 18,446,744,073,709,551,615 | Unsigned integer |

#### Floating-Point Types

| Type | Size | Precision | Range |
|------|------|-----------|-------|
| `float` | 32-bit | ~6-9 digits | ±1.5 x 10⁻⁴⁵ to ±3.4 x 10³⁸ |
| `double` | 64-bit | ~15-17 digits | ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸ |
| `decimal` | 128-bit | 28-29 digits | ±1.0 x 10⁻²⁸ to ±7.9228 x 10²⁸ |

#### Other Value Types

| Type | Size | Values | Description |
|------|------|--------|-------------|
| `bool` | 8-bit | `true` or `false` | Boolean value |
| `char` | 16-bit | U+0000 to U+FFFF | Unicode character |

#### Example

```csharp
// Integral types
int age = 25;
long population = 7800000000L;
byte grade = 95;

// Floating-point types
float temperature = 36.5f;
double pi = 3.14159265359;
decimal price = 19.99m;

// Other value types
bool isActive = true;
char initial = 'A';
```

### Reference Types

Reference types store a reference to the memory location where the data is stored. They are allocated on the heap.

#### Common Reference Types

| Type | Description |
|------|-------------|
| `string` | Sequence of characters |
| `object` | Base type for all types |
| `dynamic` | Type checking is deferred until runtime |
| `class` | User-defined reference type |
| `interface` | Contract for classes |
| `delegate` | Type-safe function pointer |
| `array` | Collection of elements of the same type |

#### Example

```csharp
// String
string name = "John Doe";
string message = "Hello, World!";

// Object
object obj = 42;
object data = "This can be anything";

// Array
int[] numbers = { 1, 2, 3, 4, 5 };
string[] names = new string[3] { "Alice", "Bob", "Charlie" };

// Class instance
Person person = new Person();
```

---

## Type Conversion

Type conversion is the process of converting a value from one data type to another.

### Implicit Conversion

Implicit conversion happens automatically when there's no risk of data loss. The compiler performs this conversion without explicit instruction.

#### Rules

- Conversion from smaller to larger integral types
- Conversion from integral types to floating-point types
- Conversion from derived class to base class

#### Example

```csharp
// Implicit conversion examples
int intValue = 100;
long longValue = intValue;           // int to long
float floatValue = intValue;         // int to float
double doubleValue = floatValue;     // float to double

byte byteValue = 10;
int intFromByte = byteValue;         // byte to int

Console.WriteLine($"int: {intValue}");
Console.WriteLine($"long: {longValue}");
Console.WriteLine($"float: {floatValue}");
Console.WriteLine($"double: {doubleValue}");
```

### Explicit Conversion (Casting)

Explicit conversion (casting) is required when there's a risk of data loss. You must explicitly specify the target type.

#### Syntax

```csharp
targetType variableName = (targetType)value;
```

#### Example

```csharp
// Explicit conversion examples
double doubleValue = 123.45;
int intValue = (int)doubleValue;     // double to int (loses decimal part)

float floatValue = 9.8f;
int intFromFloat = (int)floatValue;  // float to int

long longValue = 1000000;
int intFromLong = (int)longValue;    // long to int

Console.WriteLine($"double: {doubleValue} -> int: {intValue}");        // Output: 123
Console.WriteLine($"float: {floatValue} -> int: {intFromFloat}");      // Output: 9
```

⚠️ **Warning:** Explicit casting can result in data loss or overflow exceptions if the value is outside the target type's range.

### Conversion Methods

C# provides several methods for type conversion through the `Convert` class and type-specific parsing methods.

#### Convert Class

The `Convert` class provides methods for converting between base data types.

```csharp
// Using Convert class
string numberString = "123";
int number = Convert.ToInt32(numberString);

string boolString = "true";
bool boolValue = Convert.ToBoolean(boolString);

string doubleString = "45.67";
double doubleValue = Convert.ToDouble(doubleString);

// Convert to string
int age = 25;
string ageString = Convert.ToString(age);

Console.WriteLine($"String to int: {number}");
Console.WriteLine($"String to bool: {boolValue}");
Console.WriteLine($"String to double: {doubleValue}");
Console.WriteLine($"Int to string: {ageString}");
```

#### Parse and TryParse Methods

Each numeric type has `Parse` and `TryParse` methods for converting strings.

```csharp
// Parse method (throws exception on failure)
string text1 = "456";
int value1 = int.Parse(text1);

string text2 = "78.9";
double value2 = double.Parse(text2);

// TryParse method (returns bool, safer)
string text3 = "789";
bool success1 = int.TryParse(text3, out int value3);
if (success1)
{
    Console.WriteLine($"Parsed successfully: {value3}");
}

string invalidText = "abc";
bool success2 = int.TryParse(invalidText, out int value4);
if (!success2)
{
    Console.WriteLine("Parse failed - invalid input");
}
```

#### ToString Method

Every type in C# has a `ToString()` method for converting to string representation.

```csharp
int number = 42;
double price = 29.99;
bool isActive = true;

string numberStr = number.ToString();
string priceStr = price.ToString();
string activeStr = isActive.ToString();

Console.WriteLine($"Number: {numberStr}");
Console.WriteLine($"Price: {priceStr}");
Console.WriteLine($"Active: {activeStr}");
```

---

## Operators

Operators are symbols that perform operations on operands (variables and values).

### Arithmetic Operators

Arithmetic operators perform mathematical operations.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `+` | Addition | Adds two operands | `a + b` |
| `-` | Subtraction | Subtracts second operand from first | `a - b` |
| `*` | Multiplication | Multiplies two operands | `a * b` |
| `/` | Division | Divides first operand by second | `a / b` |
| `%` | Modulus | Returns remainder of division | `a % b` |

#### Example

```csharp
int a = 10;
int b = 3;

int sum = a + b;           // 13
int difference = a - b;    // 7
int product = a * b;       // 30
int quotient = a / b;      // 3 (integer division)
int remainder = a % b;     // 1

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");

// Division with floating-point
double x = 10.0;
double y = 3.0;
double result = x / y;     // 3.333...
Console.WriteLine($"Float Division: {result}");
```

### Comparison Operators

Comparison operators compare two values and return a boolean result.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `==` | Equal to | Checks if values are equal | `a == b` |
| `!=` | Not equal to | Checks if values are not equal | `a != b` |
| `>` | Greater than | Checks if left is greater than right | `a > b` |
| `<` | Less than | Checks if left is less than right | `a < b` |
| `>=` | Greater than or equal | Checks if left is greater or equal | `a >= b` |
| `<=` | Less than or equal | Checks if left is less or equal | `a <= b` |

#### Example

```csharp
int x = 10;
int y = 20;

bool isEqual = (x == y);           // false
bool isNotEqual = (x != y);        // true
bool isGreater = (x > y);          // false
bool isLess = (x < y);             // true
bool isGreaterOrEqual = (x >= 10); // true
bool isLessOrEqual = (y <= 20);    // true

Console.WriteLine($"x == y: {isEqual}");
Console.WriteLine($"x != y: {isNotEqual}");
Console.WriteLine($"x > y: {isGreater}");
Console.WriteLine($"x < y: {isLess}");
```

### Logical Operators

Logical operators are used to combine or invert boolean expressions.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `&&` | Logical AND | Returns true if both operands are true | `a && b` |
| `\|\|` | Logical OR | Returns true if at least one operand is true | `a \|\| b` |
| `!` | Logical NOT | Inverts the boolean value | `!a` |

#### Example

```csharp
bool hasLicense = true;
bool hasInsurance = true;
int age = 25;

// AND operator
bool canDrive = hasLicense && hasInsurance;
Console.WriteLine($"Can drive: {canDrive}"); // true

// OR operator
bool needsDocument = !hasLicense || !hasInsurance;
Console.WriteLine($"Needs document: {needsDocument}"); // false

// NOT operator
bool isMinor = !(age >= 18);
Console.WriteLine($"Is minor: {isMinor}"); // false

// Complex condition
bool canRentCar = hasLicense && (age >= 21) && hasInsurance;
Console.WriteLine($"Can rent car: {canRentCar}"); // true
```

### Assignment Operators

Assignment operators assign values to variables.

| Operator | Name | Description | Example | Equivalent |
|----------|------|-------------|---------|------------|
| `=` | Assignment | Assigns value | `a = 5` | - |
| `+=` | Add and assign | Adds and assigns | `a += 3` | `a = a + 3` |
| `-=` | Subtract and assign | Subtracts and assigns | `a -= 3` | `a = a - 3` |
| `*=` | Multiply and assign | Multiplies and assigns | `a *= 3` | `a = a * 3` |
| `/=` | Divide and assign | Divides and assigns | `a /= 3` | `a = a / 3` |
| `%=` | Modulus and assign | Modulus and assigns | `a %= 3` | `a = a % 3` |

#### Example

```csharp
int number = 10;

number += 5;  // number = 15
Console.WriteLine($"After +=: {number}");

number -= 3;  // number = 12
Console.WriteLine($"After -=: {number}");

number *= 2;  // number = 24
Console.WriteLine($"After *=: {number}");

number /= 4;  // number = 6
Console.WriteLine($"After /=: {number}");

number %= 4;  // number = 2
Console.WriteLine($"After %=: {number}");
```

### Increment/Decrement Operators

These operators increase or decrease a variable's value by 1.

| Operator | Name | Description | Example |
|----------|------|-------------|---------|
| `++` | Increment | Increases value by 1 | `a++` or `++a` |
| `--` | Decrement | Decreases value by 1 | `a--` or `--a` |

#### Pre-increment vs Post-increment

- **Pre-increment (`++a`)**: Increments first, then returns the value
- **Post-increment (`a++`)**: Returns the value first, then increments

#### Example

```csharp
// Post-increment
int a = 5;
int b = a++;  // b = 5, a = 6
Console.WriteLine($"Post-increment: a = {a}, b = {b}");

// Pre-increment
int x = 5;
int y = ++x;  // y = 6, x = 6
Console.WriteLine($"Pre-increment: x = {x}, y = {y}");

// Post-decrement
int m = 10;
int n = m--;  // n = 10, m = 9
Console.WriteLine($"Post-decrement: m = {m}, n = {n}");

// Pre-decrement
int p = 10;
int q = --p;  // q = 9, p = 9
Console.WriteLine($"Pre-decrement: p = {p}, q = {q}");

// Common usage in loops
int counter = 0;
counter++;
Console.WriteLine($"Counter: {counter}"); // 1
```

---

## Control Flow

Control flow statements determine the order in which code is executed.

### Conditional Statements

Conditional statements execute different code blocks based on conditions.

#### if Statement

Executes a block of code if a specified condition is true.

**Syntax:**
```csharp
if (condition)
{
    // code to execute if condition is true
}
```

**Example:**
```csharp
int age = 18;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

#### if-else Statement

Executes one block if condition is true, another if false.

**Syntax:**
```csharp
if (condition)
{
    // code if true
}
else
{
    // code if false
}
```

**Example:**
```csharp
int temperature = 25;

if (temperature > 30)
{
    Console.WriteLine("It's hot outside.");
}
else
{
    Console.WriteLine("The weather is pleasant.");
}
```

#### if-else if-else Statement

Tests multiple conditions in sequence.

**Syntax:**
```csharp
if (condition1)
{
    // code if condition1 is true
}
else if (condition2)
{
    // code if condition2 is true
}
else
{
    // code if all conditions are false
}
```

**Example:**
```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (score >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}
```

#### switch Statement

Selects one of many code blocks to execute based on a value.

**Syntax:**
```csharp
switch (expression)
{
    case value1:
        // code block
        break;
    case value2:
        // code block
        break;
    default:
        // code block
        break;
}
```

**Example:**
```csharp
int dayNumber = 3;

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

// Switch with string
string role = "admin";

switch (role)
{
    case "admin":
        Console.WriteLine("Full access granted");
        break;
    case "user":
        Console.WriteLine("Limited access granted");
        break;
    case "guest":
        Console.WriteLine("Read-only access");
        break;
    default:
        Console.WriteLine("No access");
        break;
}
```

#### Ternary Operator

A shorthand for simple if-else statements.

**Syntax:**
```csharp
condition ? valueIfTrue : valueIfFalse
```

**Example:**
```csharp
int age = 20;
string status = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine(status); // Output: Adult

int a = 10, b = 20;
int max = (a > b) ? a : b;
Console.WriteLine($"Maximum: {max}"); // Output: 20

// Nested ternary (use sparingly)
int score = 85;
string grade = (score >= 90) ? "A" : (score >= 80) ? "B" : (score >= 70) ? "C" : "F";
Console.WriteLine($"Grade: {grade}"); // Output: B
```

### Loops

Loops execute a block of code repeatedly based on a condition.

#### for Loop

Executes a block of code a specific number of times.

**Syntax:**
```csharp
for (initialization; condition; increment)
{
    // code block
}
```

**Example:**
```csharp
// Print numbers 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Iterate through array
string[] fruits = { "Apple", "Banana", "Orange" };
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"{i + 1}. {fruits[i]}");
}

// Nested loop - multiplication table
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}
```

#### while Loop

Executes a block of code while a condition is true.

**Syntax:**
```csharp
while (condition)
{
    // code block
}
```

**Example:**
```csharp
// Count from 1 to 5
int count = 1;
while (count <= 5)
{
    Console.WriteLine(count);
    count++;
}

// User input validation
string input;
while (true)
{
    Console.Write("Enter 'exit' to quit: ");
    input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    Console.WriteLine($"You entered: {input}");
}

// Calculate sum
int sum = 0;
int number = 1;
while (number <= 10)
{
    sum += number;
    number++;
}
Console.WriteLine($"Sum of 1 to 10: {sum}");
```

#### do-while Loop

Executes code at least once, then repeats while condition is true.

**Syntax:**
```csharp
do
{
    // code block
} while (condition);
```

**Example:**
```csharp
// Always executes at least once
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);

// Menu system
int choice;
do
{
    Console.WriteLine("\n=== Menu ===");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");
    Console.Write("Enter choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            Console.WriteLine("Option 1 selected");
            break;
        case 2:
            Console.WriteLine("Option 2 selected");
            break;
        case 3:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
} while (choice != 3);
```

#### foreach Loop

Iterates through elements in a collection or array.

**Syntax:**
```csharp
foreach (dataType variable in collection)
{
    // code block
}
```

**Example:**
```csharp
// Iterate through array
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

// Iterate through string array
string[] names = { "Alice", "Bob", "Charlie" };
foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}!");
}

// Iterate through string characters
string word = "Hello";
foreach (char c in word)
{
    Console.WriteLine(c);
}

// Iterate through list
List<string> cities = new List<string> { "New York", "London", "Tokyo" };
foreach (string city in cities)
{
    Console.WriteLine(city);
}
```

### Jump Statements

Jump statements transfer control to another part of the program.

#### break Statement

Exits a loop or switch statement prematurely.

**Example:**
```csharp
// Exit loop when condition met
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break; // Exit loop when i is 5
    }
    Console.WriteLine(i);
}
// Output: 1, 2, 3, 4

// Search in array
int[] numbers = { 10, 20, 30, 40, 50 };
int searchValue = 30;
bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchValue)
    {
        Console.WriteLine($"Found {searchValue} at index {i}");
        found = true;
        break;
    }
}
```

#### continue Statement

Skips the current iteration and continues with the next one.

**Example:**
```csharp
// Skip even numbers
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i); // Only prints odd numbers
}
// Output: 1, 3, 5, 7, 9

// Skip specific values
int[] scores = { 85, 90, -1, 78, 95, -1, 88 };
foreach (int score in scores)
{
    if (score == -1)
    {
        continue; // Skip invalid scores
    }
    Console.WriteLine($"Score: {score}");
}
```

#### return Statement

Exits from a method and optionally returns a value.

**Example:**
```csharp
// Method with return value
static int Add(int a, int b)
{
    return a + b; // Returns sum and exits method
}

// Early return for validation
static string GetGrade(int score)
{
    if (score < 0 || score > 100)
    {
        return "Invalid score"; // Exit early
    }
    
    if (score >= 90) return "A";
    if (score >= 80) return "B";
    if (score >= 70) return "C";
    if (score >= 60) return "D";
    return "F";
}

// Void method with return
static void ProcessData(int value)
{
    if (value < 0)
    {
        Console.WriteLine("Invalid input");
        return; // Exit method without value
    }
    
    Console.WriteLine($"Processing: {value}");
    // More processing...
}
```

---

## Getting Started

To begin working with C# and .NET:

1. **Install the .NET SDK**
   - Download from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
   - Verify installation: `dotnet --version`

2. **Choose an IDE**
   - Visual Studio (Windows/Mac)
   - Visual Studio Code (Cross-platform)
   - JetBrains Rider (Cross-platform)

3. **Create your first project**
   ```bash
   dotnet new console -n MyFirstApp
   cd MyFirstApp
   dotnet run
   ```

4. **Basic Project Structure**
   ```
   MyFirstApp/
   ├── Program.cs
   ├── MyFirstApp.csproj
   └── obj/
   ```

---

## Resources

### Official Documentation
- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)

### Learning Resources
- [Microsoft Learn - C# Path](https://docs.microsoft.com/en-us/learn/paths/csharp-first-steps/)
- [C# Corner](https://www.c-sharpcorner.com/)
- [Stack Overflow - C#](https://stackoverflow.com/questions/tagged/c%23)

### Community
- [.NET Foundation](https://dotnetfoundation.org/)
- [C# Discord Community](https://discord.gg/csharp)
- [Reddit r/csharp](https://www.reddit.com/r/csharp/)

---

