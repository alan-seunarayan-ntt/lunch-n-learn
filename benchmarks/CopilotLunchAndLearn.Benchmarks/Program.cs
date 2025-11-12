using BenchmarkDotNet.Running;

// Run all benchmarks in this assembly. Use filters like --filter *Prime*
BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

