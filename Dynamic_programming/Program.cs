class Program
{
    // Factorial number using memoization
    public static int Factorial(int n, Dictionary<int, int> memo)
    {
        if (n <= 1) return 1;
        if (memo.TryGetValue(n, out int value))
        {
            return value;
        }
        memo[n] = n * Factorial(n - 1, memo);
        return memo[n];
    }

    // fibonacci using memoization

    public static int FibonacciMemo(int n, Dictionary<int, int> memo)
    {
        if (n <= 1) return n;

        if (memo.TryGetValue(n, out int value))
        {
            return value;
        }

        memo[n] = FibonacciMemo(n - 2, memo) + FibonacciMemo(n - 1, memo);
        return memo[n];
    }

    // Fibonacci using tabulation
    public static int FibonacciTabu(int n)
    {
        if (n <= 1) return n;
        int[] fibo = new int[n + 1];

        fibo[0] = 0;
        fibo[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        return fibo[n];
    }

    // Longest Increasing Subsequesnce (LIS)
    public static int LIS(int[] arr)
    {
        int n = arr.Length;
        int[] memo = new int[n];

        for (int i = 0; i < n; i++)
        {
            memo[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i])
                {
                    memo[i] = Math.Max(memo[i], memo[j] + 1);
                }
            }
        }
        return memo.Max();
    }

    public static void Main(string[] args)
    {
        int[] arr = [3, 4, -1, 0, 6, 2, 3];
        // int result = LIS(arr);
        // Console.WriteLine(result);

        int result = Factorial(3, []);
        Console.WriteLine(result);
    }
}