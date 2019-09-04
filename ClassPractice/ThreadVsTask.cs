using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace ClassPractice
{
    [MemoryDiagnoser]
    public class ThreadVsTask
    {

        public async Task SaveDataTask()
        {
            await Task.Delay(3000);
            Console.WriteLine("SaveData Done");
        }
        public async Task PrintDataTask()
        {
            await Task.Delay(2000);
            Console.WriteLine("PrintData Done");
        }
        [Benchmark]
        public void UsingThread()
        {
            var t1 = new Thread(SaveData);
            var t2 = new Thread(PrintData);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        [Benchmark]
        public void UsingTask()
        {
            Task.Run(async () =>
            {
                var Task1 = SaveDataTask();
                var Task2 = PrintDataTask();

                Task.WhenAll(Task1, Task2);
            }).GetAwaiter().GetResult();
        }

        public void SaveData()
        {
            Thread.Sleep(4000);
            Console.WriteLine("SaveData Called");
        }

        public void PrintData()
        {
            Thread.Sleep(3000);
            Console.WriteLine("PrintData Called");
        }
    }
}
