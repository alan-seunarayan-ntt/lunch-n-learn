# Copilot Prompts — Lunch & Learn

These prompts help guide a collaborative session. Paste them into your IDE’s Copilot chat or inline prompts while editing the project files.

## Getting Oriented
- Explain what `Program.cs` does in `src/CopilotLunchAndLearn/Program.cs`.
- Summarize tests in `tests/CopilotLunchAndLearn.Tests/*` and what they cover.

## Safer CLI
- The CLI now uses `System.CommandLine`. Ask Copilot to add a global `--format json` option and update handlers to print JSON objects instead of plain text when specified.
- Improve error handling and return non-zero exit codes for invalid usage. Propose friendly messages and usage examples.

## New Features
- Add a new command `repeat <text> --times <n>` that repeats text `n` times, default 1.
- Add `--format json` option to output results as JSON for `greet` and `calc`.

## Prime Numbers
- Add a `calc is-prime <n>` command that returns whether `n` is a prime number. Implement an efficient check (handle n < 2). Print `true/false` (and support `--format json`).
- Add a `calc primes --up-to <n>` command that prints all primes up to `n` (inclusive). Use a simple sieve; keep it readable.
- Write xUnit tests for `is-prime` logic and for generating primes up to N. Include edge cases: 0, 1, 2, small primes, and large-ish numbers (e.g., 997).
- Optional: Expose prime utilities in `CopilotLunchAndLearn.Core` as `PrimeUtils.IsPrime(int)` and `PrimeUtils.GetPrimesUpTo(int)` and test them directly.

## Performance & Benchmarks
- The project includes intentionally slow methods in `CopilotLunchAndLearn.Core/PrimeUtils.cs`:
  - `IsPrimeInefficient(int)` and `GetPrimesUpToInefficient(int)`.
- Run benchmarks: `dotnet run -c Release --project benchmarks/CopilotLunchAndLearn.Benchmarks -- --filter *Prime*`
- Prompt: “Implement `PrimeUtils.IsPrimeFast(int)` using a sqrt(n) loop and `PrimeUtils.GetPrimesUpTo(int)` using a Sieve of Eratosthenes. Add a new benchmark that compares the sieve to the inefficient version for N=10k/50k/100k. Show speedup and memory differences.”
- Prompt: “Optimize allocations in prime generation (e.g., use `Span<bool>` or bitset) and re-run benchmarks with `MemoryDiagnoser`.”
- Prompt: “Add a CLI command `calc primes --up-to <n>` that uses the optimized implementation, and support `--format json`.”

## Tests
- Write tests for new `MathUtils` methods (subtract, multiply, divide) including edge cases.
- Add tests for the CLI by invoking the executable with arguments, capturing stdout/stderr, and asserting on results. Ask Copilot for an approach to test System.CommandLine handlers.

## Code Quality
- Add XML documentation comments and enable `<TreatWarningsAsErrors>` in `.csproj`.
- Introduce logging with `Microsoft.Extensions.Logging` and log inputs/outputs at `Debug` level.

## DevEx
- Add a `global.json` pinned to .NET 10 SDK, and mention how to update.

## CI
- Review the included GitHub Actions workflow at `.github/workflows/dotnet.yml`. Ask Copilot to add caching and coverage report upload (e.g., to Codecov) and matrix builds for multiple OSes and .NET versions.

## Stretch Ideas
- Create a `CopilotLunchAndLearn.Api` minimal API exposing `/greet` and `/calc/add` endpoints.
- Package the console as a dotnet tool (`dotnet tool install -g CopilotLunchAndLearn`).

Tip: When Copilot’s first answer isn’t right, iterate: “Revise to handle invalid inputs gracefully and add helpful usage text.”
