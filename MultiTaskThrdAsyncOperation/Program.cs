using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        private static void TaskUsingAction()
        {
            Console.WriteLine("This Task is Creatted using action.\n");
        }

        private static void TaskUsingDelegate()
        {
            Console.WriteLine("This Task is created using Delegate.\n");
        }

        private static void TaskUsingAsyncAwait()
        {
            Console.WriteLine("This Task is created using Async and Await.\n");
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static async void AsyncTask()
        {
            await Task.Run(() => TaskUsingAsyncAwait());
        }

        private static async void SolveTheMath(int firstInt, int secondtInt)
        {
            int result = await Task.FromResult(Add(firstInt, secondtInt));
            await Task.Delay(1000);
            Console.WriteLine("Result = " + result.ToString());
        }

        // Multi Threading
        private static void StartCounting()
        {
            var thread = new Thread(() =>
            {
                for (var x = 0; x < 10; x++)
                {
                    Console.Write("{0}... ", x);
                    Thread.Sleep(1000);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("==================Asynchronous Operation======================\n");

            Task actionTask = new Task(new Action(TaskUsingAction)); //Creating a Task using Action
            actionTask.Wait(1000);
            actionTask.Start();

            Task delegateTask = new Task(delegate { TaskUsingDelegate(); }); //Creating a Task using Delegate.
            delegateTask.Wait(1000);
            delegateTask.Start();

            AsyncTask(); //Creating a Task using Async and Await.

            Console.Write("\nFirst Integer = ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Second Integer = ");
            int secondtInt = int.Parse(Console.ReadLine());

            SolveTheMath(firstInt, secondtInt); //Creating a Task using FromResult Method.

            // Multi Threading
            Console.WriteLine();
            Console.WriteLine("======== Multi Threading ========");
            Console.WriteLine("Start counting...");
            StartCounting();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine("Exiting...");

            Console.ReadKey();
        }
    }
}
