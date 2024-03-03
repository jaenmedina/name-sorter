using NameSorter.IO;
using NameSorter.Models;
using NameSorter.Utils;

namespace NameSorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = args[0];
            string targetPath = args[1];

            List<FullName> fullNames = new List<FullName>();

            try
            {
                fullNames = FileReader.ReadNames(sourcePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not read the source file.");
                return;
            }
            
            PrintNames(fullNames);
            fullNames = Sorter.SortNames(fullNames);
            PrintNames(fullNames);

            try
            {
                FileWriter.WriteNames(fullNames, targetPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not write names to target file.");
                return;
            }
        }

        static void PrintNames(List<FullName> fullNames)
        {
            foreach(FullName fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }
            Console.WriteLine();
        }
    }
}