// Problem 14. Integer calculations 
//*	Write methods to calculate `minimum`, `maximum`, `average`, `sum` and `product` of given set of integer numbers. 
//*	Use variable number of arguments. ﻿

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Min(10, 5, -3, 11, 100);
        Max(0, 7, -4, 10, 88);
        Average(3, 6, -9, 10);
        Product(9, 4, -4, 13);
        Sum(11, -4, 10);
    }


    static void Min(params int[] numbers)
    {
        int min = int.MaxValue;
        foreach (var item in numbers)
        {
            if (item < min)
            {
                min = item;
            }
        }
        Console.WriteLine("Min: " + min);
    }


    static void Max(params int[] numbers)
    {
        int max = int.MinValue;
        foreach (var item in numbers)
        {
            if (item > max)
            {
                max = item;
            }
        }

        Console.WriteLine("Max: " + max);
    }


    static void Average(params int[] numbers)
    {
        Decimal sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }

        Console.WriteLine("Average: " + sum / numbers.Length);
    }


    static void Product(params int[] numbers)
    {
        BigInteger product = 1;
        foreach (var item in numbers)
        {
            product *= item;
        }


        Console.WriteLine("Product: " + product);
    }


    static void Sum(params int[] numbers)
    {
        BigInteger sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }


        Console.WriteLine("Sum: " + sum);
    }
}
