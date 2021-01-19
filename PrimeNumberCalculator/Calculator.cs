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
            return numbers.FindAll(isOdd);
        }
        private bool isOdd(int number)
        {
            return number % 2 == 1;
        }

        public bool HasEven(List<int> numbers)
        {
            return Exists(numbers, number => number % 2 == 0);
        }

        public List<int> FindEven(List<int> numbers)
        {
            return numbers.FindAll(isEven);
        }
        private bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public List<int> DoubleAll(List<int> numbers)
        {
            return (from number in numbers
                    select isDoubled(number)).ToList(); // convert to LINQ
        }

        private int isDoubled(int number)
        {
            return number * 2;
        }

        public List<int> SquareAll(List<int> numbers)
        {
            /* List<int> squaredNumbers = new List<int>();
            foreach (var number in numbers)
            {
                squaredNumbers.Add(number * number);
            }
            return squaredNumbers; */
            return numbers.Select(number => number * number).ToList(); // convert to LINQ (call form)
        }
        private int isSquared(int number)
        {
            return number * number;
        }
    }
}