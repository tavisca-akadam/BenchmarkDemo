using System.Text;
using BenchmarkDotNet.Attributes;

namespace ClassPractice
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void UsingString()
        {
            string message = "Hello";
           
            for(int i = 0; i < 10000; i++)
            {
                message += i;
            }
        }

        [Benchmark]
        public void UsingStringBuilder()
        {
            StringBuilder stringBuilderMessage = new StringBuilder("Hello");
            for(int i = 0; i < 10000; i++)
            {
                stringBuilderMessage.Append(i);
            }
        }
    }
}
