namespace NameSorter.Models
{
    public class FullName
    {
        public string GivenNames { get; set; }
        public string LastName { get; set; }

        public FullName(string givenNames, string lastName)
        {
            GivenNames = givenNames;
            LastName = lastName;
        }

        public override string ToString() => GivenNames + " " + LastName;
    }
}