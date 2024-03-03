using NameSorter.Models;
using NameSorter.Utils;

namespace NameSorter.IO
{
    public class FileReader
    {
        public static List<FullName> ReadNames(string path)
        {
            List<FullName> fullNames = new List<FullName>();
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    (string givenNames, string lastName) = NameSplitter.SplitFullName(line);
                    FullName fullName = new FullName(givenNames, lastName);
                    fullNames.Add(fullName);
                }
            }
            return fullNames;
        }
    }
}