using System.Collections.Generic;

namespace EulerLibrary.Helpers
{
    public class FibonacciGenerator
    {
        private readonly double maxSum;
        public List<int> FibonacciList = new List<int>();
        private readonly int totalCount;

        /// <summary>
        /// Generates a list of Fibonacci numbers up to a certain iteration.
        /// </summary>
        /// <param name="totalCount">How many iterations.</param>
        /// <param name="maxSum">The highest Fibonacci value to go to.</param>
        public FibonacciGenerator(int totalCount, int maxSum)
        {
            CreateDefaultValues();
            this.totalCount = totalCount;
            this.maxSum = maxSum;
            if (maxSum > 0 || totalCount > 2)
                CreateRestOfListRecursively(2);
        }

        private void CreateDefaultValues()
        {
            FibonacciList.Add(0);
            FibonacciList.Add(1);
        }

        private void CreateRestOfListRecursively(int currentPosition)
        {
            if (totalCount != 0 && currentPosition >= totalCount) return;
            var prev1 = FibonacciList[currentPosition - 1];
            var prev2 = FibonacciList[currentPosition - 2];
            var sum = prev1 + prev2;
            if (sum > maxSum)
                return;
            FibonacciList.Add(prev1 + prev2);
            currentPosition += 1;
            CreateRestOfListRecursively(currentPosition);
        }

        public static int Fibonacci(int n)
        {
            if (0 == n)
                return 0;
            if (1 == n)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}