
using System.IO;
namespace _01.Structure
{
    public static class PathStorage
    {
        public static void SavePath(Path pathToSave, string filePath)
        {
            using (StreamWriter wr = new StreamWriter(filePath))
            {
                for (int i = 0; i < pathToSave.Count; i++)
                {
                    wr.WriteLine("{0}|{1}|{2}", pathToSave[i].X, pathToSave[i].Y, pathToSave[i].Z);
                }
            }
            System.Console.WriteLine("Path points saved.");
        }

        public static Path LoadPath(Path somePath,string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    char[] separators = { '|' };
                    string[] valuesAsString = line.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
                    double[] values = new double[valuesAsString.Length];

                    for (int i = 0; i < valuesAsString.Length; i++)
                    {
                        values[i] = double.Parse(valuesAsString[i]);
                    }

                    somePath.AddPoint(new Point3D(values[0], values[1], values[2]));
                    line = sr.ReadLine();
                }
            }
            System.Console.WriteLine("Points loaded.");
            return somePath;
        }

    }
}
