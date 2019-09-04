using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ClassPractice
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class ArrayVsList
    {
        [Benchmark]
        public void UsingArray()
        {
            int[] array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = i;
            }
        }

        [Benchmark]
        public void UsingList()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }
            
        }
    }
}
