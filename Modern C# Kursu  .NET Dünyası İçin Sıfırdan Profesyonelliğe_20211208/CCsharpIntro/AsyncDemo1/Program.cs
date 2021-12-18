using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    internal class Program
    {
        static void Main(string[] args) //Main thread veya UI thread
        {
            //Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");

            //Task task1 = new Task(Process1);
            //task1.Start();

            //Task task1 = Task.Factory.StartNew(Process1);

            //Task task1 = Task.Run(Process1);

            //Task task1 = Task.Run(() =>
            //{
            //    Process1();
            //    Process2();
            //});

            //Process1AndProcess2();

            //Task task1 = Task.Run(Process1);

            //task1.Wait();

            //Process2();
            //Console.ReadKey();

            Console.WriteLine($"Main Thread başladı. Thread No : {Thread.CurrentThread.ManagedThreadId}");

            Task task1 = Task.Run(Process1);
            Task task2 = Task.Run(Process2);

            Task<int> task3 = Task.Run(Calculate);

            Console.WriteLine($"İşlem sonucunda dönen sayı {task3.Result}");

            //Task<List<Product>> task = Task.Run(GetAll);

            Console.ReadKey();
        }

        private static Task<int> Calculate()
        {
            throw new NotImplementedException();
        }

        static void Process1()
        {
            Console.WriteLine("1. İşleme başladım");
            Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Process2()
        {
            Console.WriteLine("2. İşleme başladım");
            Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");

        }

        static void Process1AndProcess2()
        {
            Process1();
            Process2();
        }

    }
}
