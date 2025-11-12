# GitHub Copilot Lunch & Learn — Delivery Guide

Duration: 45–60 minutes (adjust per audience)
Audience: C#/.NET developers (beginner–intermediate with Copilot)
Repo: This project (CLI + Core + Tests + Benchmarks)

## Learning Goals
- Use Copilot effectively inside a .NET 10 C# repo
- Practice clear prompts that produce useful code/tests
- Navigate a small solution: CLI, library, tests, CI
- Recognize and improve inefficient code with benchmarks

## Agenda (Timed)
1) Welcome & Setup — 5 min
2) Project Tour — 5 min
3) Live Demo: CLI Basics — 10 min
4) Pair with Copilot: Feature Add — 12 min
5) Tests with xUnit — 6 min
6) Performance Pitfall + Benchmarks — 8 min
7) CI Overview — 5 min
8) Wrap‑Up & Q&A — 4 min

---

## 1) Welcome & Setup — 5 min
Slide: Session Goals
- Explain what Copilot is (AI pair programmer) and isn’t (not a replacement for review).
- Show objectives: prompts, CLI walkthrough, tests, performance, CI.
- Mention privacy/security and reviewing code before merging.
- Confirm environment: .NET SDK installed; run `dotnet --info`.

Talking Points
- “We’ll keep it small, working, and extensible.”
- “We’ll use Copilot for scaffolding, refactors, and tests.”

Live:
- `dotnet build`
- Open `README.md` to show run commands.

## 2) Project Tour — 5 min
Slide: Solution Layout
- `src/CopilotLunchAndLearn` — System.CommandLine CLI
- `src/CopilotLunchAndLearn.Core` — `GreetingService`, `MathUtils`, `PrimeUtils`
- `tests/CopilotLunchAndLearn.Tests` — xUnit tests
- `benchmarks/...Benchmarks` — BenchmarkDotNet
- `PROMPTS.md` — curated prompt ideas

Talking Points
- Small footprint to make Copilot-generated changes easy to review.
- Clear seams for adding features and tests.

## 3) Live Demo: CLI Basics — 10 min
Slide: CLI Commands
- `greet <name>` → greeting from `GreetingService`
- `calc add|subtract|multiply|divide <a> <b>` → numeric result; divide-by-zero handled

Live:
- `dotnet run --project src/CopilotLunchAndLearn -- greet Alice`
- `dotnet run --project src/CopilotLunchAndLearn -- calc multiply 4 2.5`
- Open `Program.cs` to show `System.CommandLine` setup and handlers.

Prompt Cues (from PROMPTS.md)
- “Add a global `--format json` option and print JSON results.”
- “Improve error messages and exit codes for invalid inputs.”

## 4) Pair with Copilot: Feature Add — 12 min
Slide: Build a Small Feature Together
- Option A: Add `repeat <text> --times <n>` command.
- Option B: Add `--format json` to `greet` and `calc`.

Live:
- Ask Copilot to propose code changes; iterate on validation and help text.
- Run the app to verify behavior.

Prompt Cues
- “Refactor handlers to share output formatting.”
- “Add argument validation and friendly usage examples.”

## 5) Tests with xUnit — 6 min
Slide: Unit Tests
- Show `MathUtilsTests.cs` and `GreetingServiceTests.cs`.
- Emphasize deterministic functions and edge cases.

Live:
- `dotnet test`
- Ask Copilot to write tests for a new method or scenario.

Prompt Cues
- “Write tests for divide-by-zero and floating precision.”
- “Suggest property-based test ideas or more edge cases.”

## 6) Performance Pitfall + Benchmarks — 8 min
Slide: Inefficient vs Optimized
- Show `PrimeUtils.IsPrimeInefficient` and `GetPrimesUpToInefficient`.
- Introduce Big‑O briefly and why naive loops are slow.

Live:
- `dotnet run -c Release --project benchmarks/CopilotLunchAndLearn.Benchmarks -- --filter *Prime*`
- Discuss MemoryDiagnoser and how to compare implementations.

Prompt Cues (from PROMPTS.md)
- “Implement `IsPrimeFast(int)` using sqrt(n).”
- “Implement `GetPrimesUpTo(int)` using a sieve and add a comparative benchmark.”
- “Reduce allocations (Span/bitset) and re‑run.”

## 7) CI Overview — 5 min
Slide: GitHub Actions
- Show `.github/workflows/dotnet.yml` → build + test on push/PR.
- Benefits: fast feedback, consistency, quality gates.

Prompt Cues
- “Add caching, coverage upload, and a matrix for OS/.NET versions.”

## 8) Wrap‑Up & Q&A — 4 min
Slide: Takeaways
- Start small; write clear prompts; iterate.
- Keep tests close to code; run often.
- Measure performance; optimize where it matters.
- Use CI to protect your main branch.

Resources
- `README.md` for commands
- `PROMPTS.md` for exercises
- BenchmarkDotNet docs; System.CommandLine docs

---

## Pre‑Session Checklist
- Confirm .NET SDK installed (use `net8.0`/`net9.0` locally if `net10.0` isn’t available).
- Run `dotnet restore`, `dotnet build`, `dotnet test` successfully.
- Optional: warm up benchmark run once to avoid JIT surprises.
- Ensure GitHub Actions is enabled on the repo (if demoing CI).

## Optional Backup (Minimal API URL Shortener)
- If CLI isn’t ideal for your audience, switch to a small minimal API demo (scaffold endpoints, add integration tests). See the “Backup Idea” in previous notes.
