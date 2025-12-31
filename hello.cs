using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║       C# FUNDAMENTALS - COMPLETE EXAMPLES             ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝\n");

            // Run all examples
            HelloWorldExample();
            TwoSumExample();
            StringConcatenationExample();
            DataTypesExample();
            TypeConversionExample();
            ArithmeticOperatorsExample();
            ComparisonOperatorsExample();
            LogicalOperatorsExample();
            AssignmentOperatorsExample();
            IncrementDecrementExample();
            IfStatementExample();
            IfElseExample();
            IfElseIfExample();
            SwitchStatementExample();
            TernaryOperatorExample();
            ForLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();
            ForeachLoopExample();
            BreakStatementExample();
            ContinueStatementExample();
            ReturnStatementExample();

            Console.WriteLine("\n╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║              ALL EXAMPLES COMPLETED!                  ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // ============================================================
        // BASIC EXAMPLES
        // ============================================================

        static void HelloWorldExample()
        {
            PrintHeader("1. HELLO WORLD");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to C# Programming!");
            PrintSeparator();
        }

        static void TwoSumExample()
        {
            PrintHeader("2. TWO SUM PROGRAM");

            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;

            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");
            Console.WriteLine($"Sum: {num1} + {num2} = {sum}");

            PrintSeparator();
        }

        static void StringConcatenationExample()
        {
            PrintHeader("3. STRING CONCATENATION");

            string firstName = "John";
            string lastName = "Doe";

            // Method 1: Using + operator
            string fullName1 = firstName + " " + lastName;
            Console.WriteLine($"Using + operator: {fullName1}");

            // Method 2: Using string interpolation
            string fullName2 = $"{firstName} {lastName}";
            Console.WriteLine($"Using interpolation: {fullName2}");

            // Method 3: Using String.Concat()
            string fullName3 = String.Concat(firstName, " ", lastName);
            Console.WriteLine($"Using Concat(): {fullName3}");

            // Method 4: Using StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome, ");
            sb.Append(firstName);
            sb.Append(" ");
            sb.Append(lastName);
            sb.Append("!");
            Console.WriteLine($"Using StringBuilder: {sb.ToString()}");

            PrintSeparator();
        }

        // ============================================================
        // DATA TYPES EXAMPLES
        // ============================================================

        static void DataTypesExample()
        {
            PrintHeader("4. DATA TYPES");

            // Integral types
            byte byteValue = 255;
            sbyte sbyteValue = -128;
            short shortValue = -32768;
            ushort ushortValue = 65535;
            int intValue = 2147483647;
            uint uintValue = 4294967295;
            long longValue = 9223372036854775807L;
            ulong ulongValue = 18446744073709551615UL;

            Console.WriteLine("=== Integral Types ===");
            Console.WriteLine($"byte: {byteValue}");
            Console.WriteLine($"sbyte: {sbyteValue}");
            Console.WriteLine($"short: {shortValue}");
            Console.WriteLine($"ushort: {ushortValue}");
            Console.WriteLine($"int: {intValue}");
            Console.WriteLine($"uint: {uintValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"ulong: {ulongValue}");

            // Floating-point types
            float floatValue = 3.14f;
            double doubleValue = 3.14159265359;
            decimal decimalValue = 19.99m;

            Console.WriteLine("\n=== Floating-Point Types ===");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"decimal: {decimalValue}");

            // Other value types
            bool boolValue = true;
            char charValue = 'A';

            Console.WriteLine("\n=== Other Value Types ===");
            Console.WriteLine($"bool: {boolValue}");
            Console.WriteLine($"char: {charValue}");

            // Reference types
            string stringValue = "Hello World";
            object objectValue = 42;
            int[] arrayValue = { 1, 2, 3, 4, 5 };

            Console.WriteLine("\n=== Reference Types ===");
            Console.WriteLine($"string: {stringValue}");
            Console.WriteLine($"object: {objectValue}");
            Console.Write("array: [");
            foreach (int num in arrayValue)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("]");

            PrintSeparator();
        }

        // ============================================================
        // TYPE CONVERSION EXAMPLES
        // ============================================================

        static void TypeConversionExample()
        {
            PrintHeader("5. TYPE CONVERSION");

            // Implicit conversion
            Console.WriteLine("=== Implicit Conversion ===");
            int intVal = 100;
            long longVal = intVal;
            float floatVal = intVal;
            double doubleVal = floatVal;

            Console.WriteLine($"int to long: {intVal} -> {longVal}");
            Console.WriteLine($"int to float: {intVal} -> {floatVal}");
            Console.WriteLine($"float to double: {floatVal} -> {doubleVal}");

            // Explicit conversion (casting)
            Console.WriteLine("\n=== Explicit Conversion (Casting) ===");
            double doubleValue = 123.45;
            int intValue = (int)doubleValue;

            float floatValue = 9.8f;
            int intFromFloat = (int)floatValue;

            Console.WriteLine($"double to int: {doubleValue} -> {intValue}");
            Console.WriteLine($"float to int: {floatValue} -> {intFromFloat}");

            // Using Convert class
            Console.WriteLine("\n=== Using Convert Class ===");
            string numberString = "123";
            int numberFromString = Convert.ToInt32(numberString);

            string boolString = "true";
            bool boolFromString = Convert.ToBoolean(boolString);

            Console.WriteLine($"String to int: \"{numberString}\" -> {numberFromString}");
            Console.WriteLine($"String to bool: \"{boolString}\" -> {boolFromString}");

            // Parse and TryParse
            Console.WriteLine("\n=== Parse and TryParse ===");
            string text1 = "456";
            int parsed1 = int.Parse(text1);
            Console.WriteLine($"Parse: \"{text1}\" -> {parsed1}");

            string text2 = "789";
            bool success = int.TryParse(text2, out int parsed2);
            Console.WriteLine($"TryParse: \"{text2}\" -> Success: {success}, Value: {parsed2}");

            string invalidText = "abc";
            bool failedParse = int.TryParse(invalidText, out int parsed3);
            Console.WriteLine($"TryParse (invalid): \"{invalidText}\" -> Success: {failedParse}");

            // ToString method
            Console.WriteLine("\n=== ToString Method ===");
            int number = 42;
            string numberStr = number.ToString();
            Console.WriteLine($"int to string: {number} -> \"{numberStr}\"");

            PrintSeparator();
        }

        // ============================================================
        // OPERATORS EXAMPLES
        // ============================================================

        static void ArithmeticOperatorsExample()
        {
            PrintHeader("6. ARITHMETIC OPERATORS");

            int a = 10;
            int b = 3;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Addition (a + b): {a + b}");
            Console.WriteLine($"Subtraction (a - b): {a - b}");
            Console.WriteLine($"Multiplication (a * b): {a * b}");
            Console.WriteLine($"Division (a / b): {a / b}");
            Console.WriteLine($"Modulus (a % b): {a % b}");

            // Floating-point division
            double x = 10.0;
            double y = 3.0;
            Console.WriteLine($"\nFloating-point division: {x} / {y} = {x / y}");

            PrintSeparator();
        }

        static void ComparisonOperatorsExample()
        {
            PrintHeader("7. COMPARISON OPERATORS");

            int x = 10;
            int y = 20;

            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x == y: {x == y}");
            Console.WriteLine($"x != y: {x != y}");
            Console.WriteLine($"x > y: {x > y}");
            Console.WriteLine($"x < y: {x < y}");
            Console.WriteLine($"x >= y: {x >= y}");
            Console.WriteLine($"x <= y: {x <= y}");

            PrintSeparator();
        }

        static void LogicalOperatorsExample()
        {
            PrintHeader("8. LOGICAL OPERATORS");

            bool hasLicense = true;
            bool hasInsurance = true;
            int age = 25;

            Console.WriteLine($"hasLicense = {hasLicense}");
            Console.WriteLine($"hasInsurance = {hasInsurance}");
            Console.WriteLine($"age = {age}");

            // AND operator
            bool canDrive = hasLicense && hasInsurance;
            Console.WriteLine($"\nAND (&&): hasLicense && hasInsurance = {canDrive}");

            // OR operator
            bool needsDocument = !hasLicense || !hasInsurance;
            Console.WriteLine($"OR (||): !hasLicense || !hasInsurance = {needsDocument}");

            // NOT operator
            bool isMinor = !(age >= 18);
            Console.WriteLine($"NOT (!): !(age >= 18) = {isMinor}");

            // Complex condition
            bool canRentCar = hasLicense && (age >= 21) && hasInsurance;
            Console.WriteLine($"Complex: hasLicense && (age >= 21) && hasInsurance = {canRentCar}");

            PrintSeparator();
        }

        static void AssignmentOperatorsExample()
        {
            PrintHeader("9. ASSIGNMENT OPERATORS");

            int number = 10;
            Console.WriteLine($"Initial value: {number}");

            number += 5;
            Console.WriteLine($"After += 5: {number}");

            number -= 3;
            Console.WriteLine($"After -= 3: {number}");

            number *= 2;
            Console.WriteLine($"After *= 2: {number}");

            number /= 4;
            Console.WriteLine($"After /= 4: {number}");

            number %= 4;
            Console.WriteLine($"After %= 4: {number}");

            PrintSeparator();
        }

        static void IncrementDecrementExample()
        {
            PrintHeader("10. INCREMENT/DECREMENT OPERATORS");

            // Post-increment
            int a = 5;
            int b = a++;
            Console.WriteLine("Post-increment (a++):");
            Console.WriteLine($"  a = {a}, b = {b}");

            // Pre-increment
            int x = 5;
            int y = ++x;
            Console.WriteLine("\nPre-increment (++x):");
            Console.WriteLine($"  x = {x}, y = {y}");

            // Post-decrement
            int m = 10;
            int n = m--;
            Console.WriteLine("\nPost-decrement (m--):");
            Console.WriteLine($"  m = {m}, n = {n}");

            // Pre-decrement
            int p = 10;
            int q = --p;
            Console.WriteLine("\nPre-decrement (--p):");
            Console.WriteLine($"  p = {p}, q = {q}");

            PrintSeparator();
        }

        // ============================================================
        // CONTROL FLOW - CONDITIONAL STATEMENTS
        // ============================================================

        static void IfStatementExample()
        {
            PrintHeader("11. IF STATEMENT");

            int age = 18;
            Console.WriteLine($"Age: {age}");

            if (age >= 18)
            {
                Console.WriteLine("Result: You are an adult.");
            }

            PrintSeparator();
        }

        static void IfElseExample()
        {
            PrintHeader("12. IF-ELSE STATEMENT");

            int temperature = 25;
            Console.WriteLine($"Temperature: {temperature}°C");

            if (temperature > 30)
            {
                Console.WriteLine("Result: It's hot outside.");
            }
            else
            {
                Console.WriteLine("Result: The weather is pleasant.");
            }

            PrintSeparator();
        }

        static void IfElseIfExample()
        {
            PrintHeader("13. IF-ELSE IF-ELSE STATEMENT");

            int score = 85;
            Console.WriteLine($"Score: {score}");

            string grade;
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"Grade: {grade}");

            PrintSeparator();
        }

        static void SwitchStatementExample()
        {
            PrintHeader("14. SWITCH STATEMENT");

            // Switch with int
            int dayNumber = 3;
            Console.WriteLine($"Day Number: {dayNumber}");

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Result: Monday");
                    break;
                case 2:
                    Console.WriteLine("Result: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Result: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Result: Thursday");
                    break;
                case 5:
                    Console.WriteLine("Result: Friday");
                    break;
                case 6:
                    Console.WriteLine("Result: Saturday");
                    break;
                case 7:
                    Console.WriteLine("Result: Sunday");
                    break;
                default:
                    Console.WriteLine("Result: Invalid day");
                    break;
            }

            // Switch with string
            Console.WriteLine();
            string role = "admin";
            Console.WriteLine($"Role: {role}");

            switch (role)
            {
                case "admin":
                    Console.WriteLine("Result: Full access granted");
                    break;
                case "user":
                    Console.WriteLine("Result: Limited access granted");
                    break;
                case "guest":
                    Console.WriteLine("Result: Read-only access");
                    break;
                default:
                    Console.WriteLine("Result: No access");
                    break;
            }

            PrintSeparator();
        }

        static void TernaryOperatorExample()
        {
            PrintHeader("15. TERNARY OPERATOR");

            int age = 20;
            string status = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Status: {status}");

            Console.WriteLine();

            int a = 10, b = 20;
            int max = (a > b) ? a : b;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Maximum: {max}");

            Console.WriteLine();

            int score = 85;
            string grade = (score >= 90) ? "A" : (score >= 80) ? "B" : (score >= 70) ? "C" : "F";
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Grade: {grade}");

            PrintSeparator();
        }

        // ============================================================
        // CONTROL FLOW - LOOPS
        // ============================================================

        static void ForLoopExample()
        {
            PrintHeader("16. FOR LOOP");

            Console.WriteLine("Counting 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"  {i}");
            }

            Console.WriteLine("\nArray iteration:");
            string[] fruits = { "Apple", "Banana", "Orange" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {fruits[i]}");
            }

            Console.WriteLine("\nMultiplication table (3x3):");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }

            PrintSeparator();
        }

        static void WhileLoopExample()
        {
            PrintHeader("17. WHILE LOOP");

            Console.WriteLine("Counting 1 to 5:");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine($"  {count}");
                count++;
            }

            Console.WriteLine("\nCalculating sum 1 to 10:");
            int sum = 0;
            int number = 1;
            while (number <= 10)
            {
                sum += number;
                number++;
            }
            Console.WriteLine($"  Sum = {sum}");

            PrintSeparator();
        }

        static void DoWhileLoopExample()
        {
            PrintHeader("18. DO-WHILE LOOP");

            Console.WriteLine("Counting 1 to 5:");
            int i = 1;
            do
            {
                Console.WriteLine($"  {i}");
                i++;
            } while (i <= 5);

            Console.WriteLine("\nExecutes at least once (condition false):");
            int x = 10;
            do
            {
                Console.WriteLine($"  Executed with x = {x}");
            } while (x < 5); // Condition is false, but executes once

            PrintSeparator();
        }

        static void ForeachLoopExample()
        {
            PrintHeader("19. FOREACH LOOP");

            Console.WriteLine("Array iteration:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"  {num}");
            }

            Console.WriteLine("\nString array iteration:");
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine($"  Hello, {name}!");
            }

            Console.WriteLine("\nString character iteration:");
            string word = "Hello";
            Console.Write("  Characters: ");
            foreach (char c in word)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nList iteration:");
            List<string> cities = new List<string> { "New York", "London", "Tokyo" };
            foreach (string city in cities)
            {
                Console.WriteLine($"  {city}");
            }

            PrintSeparator();
        }

        // ============================================================
        // CONTROL FLOW - JUMP STATEMENTS
        // ============================================================

        static void BreakStatementExample()
        {
            PrintHeader("20. BREAK STATEMENT");

            Console.WriteLine("Exit loop at 5:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine($"  Breaking at {i}");
                    break;
                }
                Console.WriteLine($"  {i}");
            }

            Console.WriteLine("\nSearch in array:");
            int[] numbers = { 10, 20, 30, 40, 50 };
            int searchValue = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    Console.WriteLine($"  Found {searchValue} at index {i}");
                    break;
                }
            }

            PrintSeparator();
        }

        static void ContinueStatementExample()
        {
            PrintHeader("21. CONTINUE STATEMENT");

            Console.WriteLine("Skip even numbers (1-10):");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"  {i}");
            }

            Console.WriteLine("\nSkip invalid scores:");
            int[] scores = { 85, 90, -1, 78, 95, -1, 88 };
            foreach (int score in scores)
            {
                if (score == -1)
                {
                    Console.WriteLine("  [Skipped invalid score]");
                    continue;
                }
                Console.WriteLine($"  Score: {score}");
            }

            PrintSeparator();
        }

        static void ReturnStatementExample()
        {
            PrintHeader("22. RETURN STATEMENT");

            Console.WriteLine("Using Add method:");
            int result = Add(10, 20);
            Console.WriteLine($"  10 + 20 = {result}");

            Console.WriteLine("\nUsing GetGrade method:");
            Console.WriteLine($"  Score 95: Grade {GetGrade(95)}");
            Console.WriteLine($"  Score 85: Grade {GetGrade(85)}");
            Console.WriteLine($"  Score 75: Grade {GetGrade(75)}");
            Console.WriteLine($"  Score 150: {GetGrade(150)}");

            Console.WriteLine("\nUsing ProcessData method:");
            ProcessData(42);
            ProcessData(-5);

            PrintSeparator();
        }

        // ============================================================
        // HELPER METHODS
        // ============================================================

        static int Add(int a, int b)
        {
            return a + b;
        }

        static string GetGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                return "Invalid score";
            }

            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "F";
        }

        static void ProcessData(int value)
        {
            if (value < 0)
            {
                Console.WriteLine($"  Invalid input: {value}");
                return;
            }

            Console.WriteLine($"  Processing value: {value}");
        }

        static void PrintHeader(string title)
        {
            Console.WriteLine($"\n{'=',60}");
            Console.WriteLine($"  {title}");
            Console.WriteLine($"{'=',60}");
        }

        static void PrintSeparator()
        {
            Console.WriteLine();
        }
    }
}