using NameSorter.Utils;

namespace NameSorter.Tests.Utils
{
    public class NameSplitterTests
    {
        [Test]
        public void SplitFullNameWithOneGivenNameTest()
        {
            string fullName = "Marin Alvarez";

            (string givenNames, string lastName) = NameSplitter.SplitFullName(fullName);

            Assert.That(givenNames, Is.EqualTo("Marin"));
            Assert.That(lastName, Is.EqualTo("Alvarez"));
        }

        [Test]
        public void SplitFullNameWithTwoGivenNameTest()
        {
            string fullName = "Beau Tristan Bentley";

            (string givenNames, string lastName) = NameSplitter.SplitFullName(fullName);

            Assert.That(givenNames, Is.EqualTo("Beau Tristan"));
            Assert.That(lastName, Is.EqualTo("Bentley"));
        }

        [Test]
        public void SplitFullNameWithThreeGivenNameTest()
        {
            string fullName = "Hunter Uriah Mathew Clarke";

            (string givenNames, string lastName) = NameSplitter.SplitFullName(fullName);

            Assert.That(givenNames, Is.EqualTo("Hunter Uriah Mathew"));
            Assert.That(lastName, Is.EqualTo("Clarke"));
        }
    }
}