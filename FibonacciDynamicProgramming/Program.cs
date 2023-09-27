namespace FibonacciDynamicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5, 35, 100, 1000
            int a = Attemp1( 35); // after 35 it takes much time to resolve
            int b = Attemp2(1000, new Dictionary<int, int>());
            int c = Attemp3(1000);
        }

        // Using recursion
        static int Attemp1(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Attemp1(n - 1) + Attemp1(n - 2);
        }

        // Using memoization
        static int Attemp2(int n, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            int result;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                result = Attemp2(n - 1, memo) + Attemp2(n - 2, memo);
            }

            memo[n] = result;
            return result;
        }

        // Using Bottom-Up
        static int Attemp3(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            int[] result = new int[n + 1];
            result[0] = 1;
            result[1] = 1;

            for (int i = 2; i < (n + 1); i++)
            {
                result[i] = (result[i - 2]) + (result[i - 1]);
            }

            return result[^1];
        }
    }
}