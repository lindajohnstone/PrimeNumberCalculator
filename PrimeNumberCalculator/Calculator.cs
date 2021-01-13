using System;
using System.Collections.Generic;

namespace PrimeNumberCalculator
{
    public class Calculator
    {
        List<int> _primeNumbers = new List<int>();
        public Calculator()
        {
        }

        public List<int> Calculate(int limit)
        {
            for (int number = 2; number < limit; number++)
            {
                for (int factor = 2; factor <= number; factor++)
                {
                    if (number != factor && number % factor == 0)
                    {
                        break;
                    }
                    if (number == factor) _primeNumbers.Add(number);
                }
            }
            return _primeNumbers;
        }
    }
}