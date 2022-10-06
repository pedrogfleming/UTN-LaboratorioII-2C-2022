``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2075/21H2/November2021Update)
Intel Core i5-10310U CPU 1.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2


```
|               Method |      Mean |     Error |    StdDev | Rank | Allocated |
|--------------------- |----------:|----------:|----------:|-----:|----------:|
|  ClearSoloListaPadre | 0.4745 ns | 0.0396 ns | 0.0616 ns |    1 |         - |
| ClearManualIterativo | 5.0622 ns | 0.1154 ns | 0.1234 ns |    2 |         - |
