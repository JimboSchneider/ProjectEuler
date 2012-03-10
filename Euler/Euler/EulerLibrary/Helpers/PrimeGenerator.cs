using System;
using System.Collections.Generic;

namespace EulerLibrary.Helpers
{
    public static class PrimeGenerator
    {
        public static List<Int64> GetPrimeArrayByMax(Int64 maxPrime)
        {
            //The goal of this snippet is to return an array of prime
            //numbers up to the maximum number provided.
            //For this we'll use a sieve method and roll forward.

            //the list that will store our numbers
            var ret = new List<Int64>();

            //This is a byte array - one per number. A '0' means the number is prime,
            //and a '1' indicates that the number is a multiple of a prior prime.

            var comp = new List<Byte>();
            comp.AddRange(new Byte[maxPrime]);

            //Define our bounds - from 2 to our maximum potential prime
            var n = maxPrime;
            var lobound = 2;

            //And now the meat of the routine - we fill up the byte array.
            //First - we know that for a given maximum, our potential multipliers
            //will not exceed the square root of our max - so there's no point in
            //looping through.
            var ubound = (Int64)Math.Sqrt(n);

            //And here is the loop
            for (var i = 2; i < ubound; i++)
            {
                //We start by finding our first prime
                //i.e. 2,3,5,7,etc. - we do this by checking our byte array,
                //since by definition our primes will be left as '0' as we
                //fill the array forward.
                if (comp[i] == 0)
                {
                    //Once we find one, we do another loop and for each multiple
                    //of this number, we can flag the corresponding position in the
                    //byte array as 1 (i.e. non-prime).  So if we start with 2, we would
                    //flag 4,6,8,etc. up until our max.  On 3, we would flag 6,9,12,etc.
                    for (var z = (i * 2); z < n; z += i)
                    {
                        comp[z] = 1;
                    }
                }
            }

            //Now that our byte array has only primes (up until our pax) still
            //flagged as zero, we can build our return list.
            for (var q = lobound; q < n; q++)
            {
                //if the byte at the corresponding array location
                //is zero, add this index to our return list
                if (comp[q] == 0)
                {
                    ret.Add(q);
                }
            }
            //and return the index.  Note that this starts at 2, since 1
            //by definition is special and is not included.
            return ret;
        }

    }
}