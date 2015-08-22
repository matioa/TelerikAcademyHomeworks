using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example")[1]);
            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example.pdf")[1]);
            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example.new.pdf")[1]);

            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example")[0]);
            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example.pdf")[0]);
            Console.WriteLine(UtilsFile.SplitFileNameAndExtension("example.new.pdf")[0]);

            Console.WriteLine("Distance in the 2D space = {0:f2}", UtilsDistance.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", UtilsDistance.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure = new Figure3D(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}

