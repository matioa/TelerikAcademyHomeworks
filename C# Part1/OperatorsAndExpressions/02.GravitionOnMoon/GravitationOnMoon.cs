//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnMoon
{
    static void Main()
    {
        Console.WriteLine("weight | weight on the Moon");

        float weightOnEarth = new float();
        double weightOnMoon;

        // Checks some weights to their weight on the Moon
        for (weightOnEarth = 46; weightOnEarth < 120; weightOnEarth += 17.5f)
        {
            weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine("{0,6} | {1}", weightOnEarth, weightOnMoon);
        }

        // Asks fo number from the user:
        Console.WriteLine();
        Console.Write("Enter weight:");
        weightOnEarth = Convert.ToSingle(Console.ReadLine());
        weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("{0,6} | {1}", weightOnEarth, weightOnMoon);
    }
}
