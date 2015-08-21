namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static decimal MySum<T>(this IEnumerable<T> numbers) where T : struct, IFormattable, IComparable, IConvertible
        {
            decimal sum = 0;
            foreach (var number in numbers)
            {
                sum += Convert.ToDecimal(number);
            }

            return sum;
        }

        public static decimal MyProduct<T>(this IEnumerable<T> numbers) where T : struct, IFormattable, IComparable, IConvertible
        {
            decimal sum = 1;
            foreach (var number in numbers)
            {
                sum *= Convert.ToDecimal(number);
            }

            return sum;
        }

        public static decimal MyAverage<T>(this IEnumerable<T> numbers) where T : struct, IFormattable, IComparable, IConvertible
        {
            decimal average = 0;
            int counter = 0;
            foreach (var number in numbers)
            {
                average += Convert.ToDecimal(number);
                counter++;
            }
            average /= counter;
            return average;
        }

        public static T MyMin<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.First();
            foreach (var item in collection)
            {
                if (min.CompareTo(item)>0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T MyMax<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.First();
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
