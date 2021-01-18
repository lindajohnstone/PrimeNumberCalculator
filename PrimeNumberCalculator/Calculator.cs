using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumberCalculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public List<int> Calculate(int limit)
        {
            List<int> primeNumbers = new List<int>();
            IEnumerable<int> numbers = Enumerable.Range(2, limit - 1);
            IsPrime(primeNumbers, numbers);
            return primeNumbers;
        }

        private static void IsPrime(List<int> primeNumbers, IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                AddPrime(primeNumbers, number);
            }
        }

        private static void AddPrime(List<int> primeNumbers, int number)
        {
            IEnumerable<int> numbers = Enumerable.Range(2, number - 2);
            bool IsPrime = !Exists(numbers, factor => number % factor == 0);
            if (IsPrime) primeNumbers.Add(number);
        }

        private static bool Exists(IEnumerable<int> numbers, Func<int, bool> condition)
        {
            foreach (int factor in numbers)
            {
                if (condition(factor)) return true;
            }
            return false;
        }
        public bool HasOdd(List<int> numbers)
        {
            return Exists(numbers, number => number % 2 == 1);
        }

        public List<int> FindOdd(int limit)
        {
            List<int> oddNumbers = new List<int>();
            IEnumerable<int> numbers = Enumerable.Range(1, limit);
            IsOdd(oddNumbers, numbers);
            return oddNumbers;
        }

        private static void IsOdd(List<int> oddNumbers, IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                AddOdd(oddNumbers, number);
            }
        }

        private static void AddOdd(List<int> oddNumbers, int number)
        {
            if (number % 2 == 1) oddNumbers.Add(number);
        }

        public bool HasEven(List<int> numbers)
        {
            return Exists(numbers, number => number % 2 == 0);
        }
    }
}