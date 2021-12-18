﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread başladı. {Thread.CurrentThread.ManagedThreadId}");
            Task task = Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1();
            Process2();
            Console.ReadKey();
        }
        static void Process1()
        {
            Console.WriteLine($"Senkron İşlem 1 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process1Async()
        {
            Thread.Sleep(1000);
            await Task.Run(() => 
            {
                Console.WriteLine($"Async İşlem 1 başladı. {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        static void Process2()
        {
            Console.WriteLine($"Senkron İşlem 2 başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process2Async()
        {
            await Task.Run(() =>
            {
               Console.WriteLine($"Async İşlem 2 başladı. {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}
