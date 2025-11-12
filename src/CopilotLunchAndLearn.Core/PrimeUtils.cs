namespace CopilotLunchAndLearn.Core;

public static class PrimeUtils
{
    // Intentionally inefficient primality check for demo purposes.
    // Complexity ~O(n). For n < 2, returns false.
    public static bool IsPrimeInefficient(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Intentionally inefficient prime generation by testing each candidate using IsPrimeInefficient.
    public static List<int> GetPrimesUpToInefficient(int n)
    {
        var primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (IsPrimeInefficient(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    // TODO (Copilot): Implement IsPrimeFast using sqrt(n) loop.
    // TODO (Copilot): Implement GetPrimesUpTo using a Sieve of Eratosthenes.
}

