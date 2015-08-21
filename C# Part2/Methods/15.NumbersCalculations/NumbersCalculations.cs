// Problem 14. Integer calculations 
//*	Write methods to calculate `minimum`, `maximum`, `average`, `sum` and `product` of given set of integer numbers. 
//*	Use variable number of arguments. ﻿

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Min(10, 5, -3.5, 11, 100);
        Max(0, 7, -4.7, 10, 88.0);
        Average(3, 6.5F, -9, 10);
        Product(9, 4, -4, 13);
        Sum(11, -4.0, 10f);
    }


    static void Min<T>(params T[] numbers) where T : IComparable<T>
    {
        var min = numbers[0];
        foreach (var item in numbers)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        Console.WriteLine("Min: " + min);
    }


    static void Max<T>(params T[] numbers) where T : IComparable<T>
    {
        var max = numbers[0];
        foreach (var item in numbers)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        Console.WriteLine("Max: " + max);
    }


    static void Average<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic sum = numbers[0];
        foreach (var item in numbers)
        {
            sum += item;
        }

        Console.WriteLine("Average: " + sum / numbers.Length);
    }


    static void Product<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic product = 1;
        foreach (var item in numbers)
        {
            product *= item;
        }
        Console.WriteLine("Product: " + product);
    }


    static void Sum<T>(params T[] numbers) where T : IConvertible
    {
        dynamic sum = numbers[0];
        sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }

        Console.WriteLine("Sum: " + sum);
    }
}
