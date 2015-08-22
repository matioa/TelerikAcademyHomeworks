using System;

namespace CohesionAndCoupling
{
    static class UtilsFile
    {

        public static string[] SplitFileNameAndExtension(string file)
        {
            string fileName;
            string fileExtension;
            string[] fileNameAndExtension = new string[2];

            int indexOfLastDot = file.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                fileName = file;
                fileExtension = string.Empty;
            }
            else
            {
                fileName = file.Substring(indexOfLastDot + 1).ToString();
                fileExtension = file.Substring(0, indexOfLastDot);
            }

            fileNameAndExtension[0]=fileName;
            fileNameAndExtension[1]=fileExtension;

            return fileNameAndExtension;
        }
    }
}

