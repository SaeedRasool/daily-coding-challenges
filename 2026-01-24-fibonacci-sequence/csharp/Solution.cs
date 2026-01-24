using System;

class Fibonacci
{
    public static long GetNth(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");
        
        if (n == 0) return 0;
        if (n == 1) return 1;

        long prev = 0;
        long curr = 1;

        for (int i = 2; i <= n; i++)
        {
            long next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr;
    }
}
