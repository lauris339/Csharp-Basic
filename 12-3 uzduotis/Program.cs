using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            const long numm = 600851475143;
            long largestFact = 0;
            long[] factors = new long[2];

            for (long i = 2; i * i < numm; i++)
            {
                if (numm % i == 0)
                {
                    factors[0] = i;
                    factors[1] = numm / i;

                    for (int k = 0; k < 2; k++)
                    {
                        bool isPrime = true;
                        for (long j = 2; j * j < factors[k]; j++)
                        {
                            if (factors[k] % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime && factors[k] > largestFact)
                        {
                            largestFact = factors[k];
                        }
                    }
                }
            }

            Console.WriteLine(largestFact);
        }
    }
}
