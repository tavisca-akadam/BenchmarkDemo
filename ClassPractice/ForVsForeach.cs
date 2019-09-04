using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ClassPractice
{
    public class ForVsForeach
    {
        [Benchmark]
        public void UsingFor()
        {
            List<int> _list1 = new List<int>();
            List<int> _list2 = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                _list1.Add(i);
            }
            for (int i = 0; i < _list1.Count; i++)
            {
                _list2.Add(_list1[i]);
            }
        }

        [Benchmark]
        public void UsingForEach()
        {
            List<int> _list3 = new List<int>();
            List<int> _list1 = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                _list1.Add(i);
            }
            foreach (var item in _list1)
            {
                _list3.Add(item);
            }
        }
    }
}
