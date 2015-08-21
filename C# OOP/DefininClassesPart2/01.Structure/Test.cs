using System;
using System.Collections.Generic;

namespace _01.Structure
{
    [Version(3,112)]
    class Test
    {
        static void Main()
        {

            //Problem 2: Static read-only field
            Console.WriteLine("==========\nProblem 2\n");
            Console.WriteLine(Point3D.StartPoint.ToString());

            //Problem3: Calculate distance between 2 points
            Console.WriteLine("==========\nProblem 3\n");

            Point3D firstPoint = new Point3D(-7, -4, 3);
            Point3D secondPoint = new Point3D(17, 6, 2.5);

            double distance = Distance.CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("Point 1: {0} \nPoint 2: {1}", firstPoint.ToString(), secondPoint.ToString());
            Console.WriteLine("Distance between the two points: {0}", distance);

            //Problem 4
            Console.WriteLine("==========\nProblem 4\n");

            Path myPoints = new Path();
            myPoints.AddPoint(firstPoint);
            myPoints.AddPoint(secondPoint);
            myPoints.AddPoint(new Point3D(2, 3, 4));
            Console.WriteLine("Total points in myPoints: {0}", myPoints.Count);
            Console.WriteLine(myPoints[0].ToString());
            Console.WriteLine(myPoints[1].ToString());
            Console.WriteLine(myPoints[2].ToString());
            Console.WriteLine("Number of Points3D in myPoints before load: {0}", myPoints.Count);
            PathStorage.SavePath(myPoints, "..\\..\\input.txt");
            PathStorage.LoadPath(myPoints, "..\\..\\input.txt");
            Console.WriteLine("Number of Points3D in myPoints after load: {0}", myPoints.Count);


            //Problem 5-6
            Console.WriteLine("==========\nProblem 5&6\n");
            GenericList<int> newList = new GenericList<int>();
            for (int i = 0; i < 30; i++)
            {
                newList.Add(i);
            }
            Console.WriteLine(newList.ToString());

            //Problem 7
            Console.WriteLine("==========\nProblem 5&6\n");
            var min = newList.Min();
            Console.WriteLine("Min value: {0}",min.ToString());
            var max = newList.Max();
            Console.WriteLine("Max value:{0}",max.ToString());


            //Problem 11
            Console.WriteLine("==========\nProblem 11\n");
            Type type = typeof(Test); 
             object[] attr = type.GetCustomAttributes(false); 
             foreach (VersionAttribute item in attr) 
             { 
                 Console.WriteLine("Version: {0}",item.Version); 
             } 



            
        }
    }
}
