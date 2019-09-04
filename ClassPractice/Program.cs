using System;
using System.Diagnostics;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            // ThreadDemo demo = new ThreadDemo();
            //var t1 = new Thread(demo.SaveData);
            //var t2 = new Thread(demo.PrintData);

            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();

            //Task.Run(async () =>
            //{
            //    var task1 = demo.SaveData();
            //    var task2 = demo.PrintData();
            //    await Task.WhenAll(task1, task2);
            //}).GetAwaiter().GetResult();
            ////demo.SaveData();
            ////demo.PrintData();
            //watch.Stop();
            //Console.WriteLine($"The time taken for Execution: {watch.ElapsedMilliseconds}");

            //var Summary = BenchmarkRunner.Run<StringVsStringBuilder>();
            //var Summary = BenchmarkRunner.Run<ForVsForeach>();
            //var Summary = BenchmarkRunner.Run<ArrayVsList>();
            var Summary = BenchmarkRunner.Run<ThreadDemo>();
            Console.ReadKey();
        }
        
    }
}
