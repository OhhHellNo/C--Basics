/*

C#

Multi-threaded by default

Designed for true parallel execution

Can use multiple CPU cores easily

 C# can run multiple threads at the same time.

Native support for threads

Multiple ways to do concurrency:

Thread

Task

Parallel

async/await
 
 */


using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("C# Multithreading Demo \n");

        ManualThreadExample();

        ThreadPoolExample();

        TaskExample().Wait();

        ParallelExample();

        AsyncAwaitExample().Wait();

        Console.WriteLine("\nAll examples completed.");
    }

    static void ManualThreadExample()
    {
        Console.WriteLine("1) Manual Threads");

        Thread t1 = new Thread(PrintNumbers);
        Thread t2 = new Thread(PrintLetters);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Manual threads finished.\n");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Number: {i}");
            Thread.Sleep(300);
        }
    }

    static void PrintLetters()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Letter: {c}");
            Thread.Sleep(300);
        }
    }

    static void ThreadPoolExample()
    {
        Console.WriteLine("2) Thread Pool");

        for (int i = 1; i <= 3; i++)
        {
            int taskId = i;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] ThreadPool Task {taskId}");
                Thread.Sleep(500);
            });
        }

        Thread.Sleep(2000); // Wait for thread pool tasks to complete
        Console.WriteLine("Thread pool tasks finished.\n");
    }


    static async Task TaskExample()
    {
        Console.WriteLine("3) Tasks");

        Task task1 = Task.Run(() => DoWork("Task 1"));
        Task task2 = Task.Run(() => DoWork("Task 2"));

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Tasks finished.\n");
    }

    static void DoWork(string name)
    {
        Console.WriteLine($"[{name}] Running on thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(700);
        Console.WriteLine($"[{name}] Finished");
    }

    static void ParallelExample()
    {
        Console.WriteLine("4) Parallel.For");

        Parallel.For(1, 6, i =>
        {
            Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Processing item {i}");
            Thread.Sleep(400);
        });

        Console.WriteLine("Parallel loop finished.\n");
    }
    static async Task AsyncAwaitExample()
    {
        Console.WriteLine("5) Async / Await");

        await Task.Delay(1000);

        Console.WriteLine($"Async work resumed on thread {Thread.CurrentThread.ManagedThreadId}");
    }
}
