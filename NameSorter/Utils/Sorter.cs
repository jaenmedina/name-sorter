using NameSorter.Models;

namespace NameSorter.Utils
{
    public class Sorter
    {
        public static List<FullName> SortNames(List<FullName> fullNames)
        {
            return fullNames.OrderBy(n => n.LastName).ThenBy(n => n.GivenNames).ToList();
        }
    }
}