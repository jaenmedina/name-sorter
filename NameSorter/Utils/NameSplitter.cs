namespace NameSorter.Utils
{
    public class NameSplitter
    {
        public static (string givenNames, string lastName) SplitFullName(string fullName)
        {
            List<string> names = fullName.Split(" ").ToList();
            string lastName = names.Last();
            names.Reverse();
            names = names.Skip(1).ToList();
            names.Reverse();
            string givenNames = string.Join(" ", names);
            return (givenNames, lastName);
        }
    }
}