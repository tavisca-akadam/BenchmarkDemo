using BenchmarkDotNet.Attributes;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassPractice
{
    [MemoryDiagnoser]
    public class ThreadDemo
    {
        //int i = 0;
        //public async Task SaveData()
        //{
        //    //Thread.Sleep(4000);
        //    await Task.Delay(4000);
        //    Console.WriteLine("SaveData Done");
        //}

        //public async Task PrintData()
        //{
        //    //Thread.Sleep(3000);
        //    await Task.Delay(3000);
        //    Console.WriteLine("PrintData Done");
        //}
        

            public void SaveDataThread()
            {
                Thread.Sleep(2000);
            }


            public void PrintDataThread()
            {
                Thread.Sleep(3000);
            }


            [Benchmark]
            public void Threads()
            {
                Thread thread1 = new Thread(SaveDataThread);
                Thread thread2 = new Thread(PrintDataThread);
                thread1.Start();
                thread2.Start();
                thread1.Join();
                thread2.Join();
            }


            [Benchmark]
            public void Tasks()
            {
                Task.Run(async () =>
                {
                    var task1 = SaveData();
                    var task2 = PrintData();
                    await Task.WhenAll(task1, task2);
                }).GetAwaiter().GetResult();

            }


            public async Task SaveData()
            {
                await Task.Delay(2000);
            }


            public async Task PrintData()
            {
                await Task.Delay(3000);
            }


        }
    }

