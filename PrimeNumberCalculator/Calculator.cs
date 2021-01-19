using System;
using System.Collections;
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

        public List<int> FindOdd(List<int> numbers)
        {
            List<int> oddNumbers = numbers.FindAll(number => number % 2 == 1);
            return oddNumbers;
        }

        public bool HasEven(List<int> numbers)
        {
            return Exists(numbers, number => number % 2 == 0);
        }

        public List<int> FindEven(List<int> numbers)
        {
            List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);
            return evenNumbers;
        }

        public List<int> DoubleAll(IEnumerable<int> numbers)
        {
            List<int> doubledNumbers = new List<int>();
            numbers = Enumerable.Range(1, 10).Select(number => number * 2);
            AddDoubledNumber(numbers, doubledNumbers);
            return doubledNumbers;
        }

        private static void AddDoubledNumber(IEnumerable<int> numbers, List<int> doubledNumbers)
        {
            foreach (var number in numbers)
            {
                doubledNumbers.Add(number);
            }
        }

        public List<int> SquareAll(IEnumerable<int> numbers)
        {
            List<int> squaredNumbers = new List<int>();
            numbers = Enumerable.Range(1, 10).Select(number => number * number);
            AddSquares(numbers, squaredNumbers);
            return squaredNumbers;
        }

        private static void AddSquares(IEnumerable<int> numbers, List<int> squaredNumbers)
        {
            foreach (var number in numbers)
            {
                squaredNumbers.Add(number);
            }
        }
    }
}