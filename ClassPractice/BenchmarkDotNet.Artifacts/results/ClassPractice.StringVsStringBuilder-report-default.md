
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742191 Hz, Resolution=364.6719 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


             Method |        Mean |      Error |       StdDev |
------------------- |------------:|-----------:|-------------:|
        UsingString | 31,882.8 us | 650.516 us | 1,690.778 us |
 UsingStringBuilder |    347.8 us |   6.896 us |     6.773 us |
