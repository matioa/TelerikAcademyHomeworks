namespace PrintStatisticsHomework
{
    using System;
    using System.Linq;

    class Statistics
    {
        public void PrintStatistics(double[] arr)
        {
            double maxValue = arr.Max();
            PrintMax(maxValue);

            double minValue = arr.Min();
            PrintMin(minValue);

            double sumValues = 0;
            int countElementsInArray = arr.Length;
            for (int i = 0; i < countElementsInArray; i++)
            {
                sumValues += arr[i];
            }
            double averageValue = sumValues / countElementsInArray;
            PrintAvg(averageValue);
        }

        public void PrintMax(double value)
        {
            Console.Write(value);
        }

        public void PrintMin(double value)
        {
            Console.Write(value);
        }

        public void PrintAvg(double value)
        {
            Console.Write(value);
        }
    }
}
