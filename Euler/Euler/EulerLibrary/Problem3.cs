using System;
using System.Collections.Generic;
using System.Linq;
using EulerLibrary.Helpers;

namespace EulerLibrary
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem3
    {
        public Int64 LargestPrime { get; set; }
        public List<Int64> PrimeList { get; set; }

        public Problem3(Int64 numToGetPrimeMax)
        {
            PrimeList = PrimeGenerator.GetPrimeArrayByMax(numToGetPrimeMax);
            Run(numToGetPrimeMax); 
        }

        void Run(long numToGetPrimeMax)
        {
            foreach (var prime in PrimeList.Where(prime => numToGetPrimeMax % prime == 0))
            {
                LargestPrime = prime;
            }
        }
    }
}