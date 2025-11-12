# Copilot Lunch & Learn — C#/.NET 10 Sample

A concise, working .NET sample to demo GitHub Copilot in a lunch-and-learn. It includes:

- Console app with a tiny CLI (`greet`, `calc add|subtract|multiply|divide`) using System.CommandLine
- Reusable core library (`GreetingService`, `MathUtils`)
- xUnit tests
- Prompt ideas for Copilot (`PROMPTS.md`)

This is intentionally simple and leaves room for guided improvements.

## Prerequisites

- .NET SDK 10 (or compatible preview) installed

If you don’t have .NET 10, you can change `<TargetFramework>` in the `.csproj` files to `net8.0` or `net9.0` to run locally.

## Quick Start

Build everything:

```
dotnet build
```

Run the console app:

```
dotnet run --project src/CopilotLunchAndLearn -- greet Alice
dotnet run --project src/CopilotLunchAndLearn -- calc add 2 3
dotnet run --project src/CopilotLunchAndLearn -- calc subtract 5 2
dotnet run --project src/CopilotLunchAndLearn -- calc multiply 4 2.5
dotnet run --project src/CopilotLunchAndLearn -- calc divide 10 2
```

Run tests:

```
dotnet test
```

## Project Layout

- `src/CopilotLunchAndLearn` — Console app entry point (CLI)
- `src/CopilotLunchAndLearn.Core` - Core services/utilities
- `tests/CopilotLunchAndLearn.Tests` - xUnit tests
- `benchmarks/CopilotLunchAndLearn.Benchmarks` - BenchmarkDotNet benchmarks
- `PROMPTS.md` - Curated Copilot prompts for exercises

## Suggested Improvements (great for Copilot)

- Add `--format json` output for all commands
- Improve validation and error handling for bad inputs
- Add logging and structured output (e.g., JSON)
- Add more calculator functions (power, sqrt), and units conversions
- Add more tests, including edge cases and property tests
- Introduce a GitHub Actions CI workflow

## CI

- GitHub Actions workflow included at `.github/workflows/dotnet.yml` that builds and tests on push/PR.

## Benchmarks

Run benchmarks (intentionally slow naive implementation):

```
dotnet run -c Release --project benchmarks/CopilotLunchAndLearn.Benchmarks -- --filter *Prime*
```

This benchmarks `PrimeUtils.GetPrimesUpToInefficient(N)` for N=10k and 20k. Use this as a starting point to optimize with a sieve and compare improvements.
