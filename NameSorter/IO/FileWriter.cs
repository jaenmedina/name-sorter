using NameSorter.Models;

namespace NameSorter.IO
{
    public class FileWriter
    {
        public static void WriteNames(List<FullName> fullNames, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (FullName fullName in fullNames)
                {
                    writer.WriteLine(fullName);
                }
            }
        }
    }
}