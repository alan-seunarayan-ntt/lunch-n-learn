using BenchmarkDotNet.Attributes;
using CopilotLunchAndLearn.Core;

namespace CopilotLunchAndLearn.Benchmarks;

[MemoryDiagnoser]
public class PrimeBenchmarks
{
    [Params(10_000, 20_000)]
    public int N;

    [Benchmark(Description = "Inefficient primes up to N")]
    public List<int> InefficientPrimes() => PrimeUtils.GetPrimesUpToInefficient(N);

    // TODO (Copilot): Add an optimized Sieve benchmark and compare.
    // Example signature (to be implemented in Core):
    // [Benchmark(Description = "Sieve primes up to N")]
    // public List<int> SievePrimes() => PrimeUtils.GetPrimesUpTo(N);
}

