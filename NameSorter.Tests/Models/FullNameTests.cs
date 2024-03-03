using NameSorter.Models;

namespace NameSorter.Tests.Models
{
    public class FullNameTests
    {
        [Test]
        public void ToStringTest()
        {
            FullName fullName = new FullName("Hunter Uriah Mathew", "Clarke");

            string fullNameString = fullName.ToString();

            Assert.That(fullNameString, Is.EqualTo("Hunter Uriah Mathew Clarke"));
        }
    }
}