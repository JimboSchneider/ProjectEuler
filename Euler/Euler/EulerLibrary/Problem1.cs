namespace EulerLibrary
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem1
    {
        readonly int count;
        public int Sum { get; set; }

        public Problem1(int count)
        {
            this.count = count;
            Run();
        }

        public int Run()
        {
            Sum = 0;
            for (var i = 1; i < count; i++)
            {
                if (i % 3 == 0)
                    Sum += i;
                else if (i % 5 == 0)
                    Sum += i;
            }

            return Sum;
        }
    }
}
