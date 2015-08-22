using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DecreasingAbsoluteDifference
{
    static void Main()
    {

        var input = ReadInput();
        Validate(input);

        foreach (var line in input)
        {
            char[] splittChars = { ' ' };

            List<long> inputNumbers = line.Split(splittChars, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            List<long> absoluteSequence = CreateSequenceOfAbsoluteDifferences(inputNumbers);
            List<long> zeroBasedAbsoluteSeq = CreateSequenceOfAbsoluteDifferences(absoluteSequence);

            bool isDecreasing = IsSequenceDecreasing(absoluteSequence);
            bool isZeroBased = IsZeroBased(zeroBasedAbsoluteSeq);

            if (isDecreasing && isZeroBased)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

    private static string[] ReadInput()
    {
        int lineNumbers = int.Parse(Console.ReadLine());
        string[] lines = new string[lineNumbers];

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = Console.ReadLine();
        }

        return lines;
    }

    private static void Validate(string[] input)
    {
        if (input == null || input.Length == 0)
        {
            throw new ArgumentNullException("Input cannot be null or empty string.");
        }
    }


    private static List<long> CreateSequenceOfAbsoluteDifferences(List<long> numbers)
    {
        List<long> absoluteDifferenceSequence = new List<long>();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            long absoluteDifference = Math.Abs(numbers[i] - numbers[i + 1]);
            absoluteDifferenceSequence.Add(absoluteDifference);
        }

        return absoluteDifferenceSequence;
    }

    private static bool IsSequenceDecreasing(List<long> sequence)
    {
        for (int i = 1; i < sequence.Count; i++)
        {
            if (sequence[i] > sequence[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsZeroBased(List<long> sequence)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] != 0 && sequence[i] != 1)
            {
                return false;
            }
        }
        return true;
    }
}