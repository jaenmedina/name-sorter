using NameSorter.Models;
using NameSorter.Utils;

namespace NameSorter.Tests.Utils
{
    public class SorterTests
    {
        [Test]
        public void SortNamesTest()
        {
            List<FullName> fullNames =
            [
                new FullName("Janet", "Parsons"),
                new FullName("Vaughn", "Lewis"),
                new FullName("Adonis Julius", "Archer"),
                new FullName("Shelby Nathan", "Yoder"),
                new FullName("Marin", "Alvarez"),
                new FullName("London", "Lindsey"),
                new FullName("Beau Tristan", "Bentley"),
                new FullName("Leo", "Gardner"),
                new FullName("Hunter Uriah Mathew", "Clarke"),
                new FullName("Mikayla", "Lopez"),
                new FullName("Frankie Conner", "Ritter"),
            ];

            fullNames = Sorter.SortNames(fullNames);

            Assert.That(fullNames[0].ToString(), Is.EqualTo("Marin Alvarez"));
            Assert.That(fullNames[1].ToString(), Is.EqualTo("Adonis Julius Archer"));
            Assert.That(fullNames[2].ToString(), Is.EqualTo("Beau Tristan Bentley"));
            Assert.That(fullNames[3].ToString(), Is.EqualTo("Hunter Uriah Mathew Clarke"));
            Assert.That(fullNames[4].ToString(), Is.EqualTo("Leo Gardner"));
            Assert.That(fullNames[5].ToString(), Is.EqualTo("Vaughn Lewis"));
            Assert.That(fullNames[6].ToString(), Is.EqualTo("London Lindsey"));
            Assert.That(fullNames[7].ToString(), Is.EqualTo("Mikayla Lopez"));
            Assert.That(fullNames[8].ToString(), Is.EqualTo("Janet Parsons"));
            Assert.That(fullNames[9].ToString(), Is.EqualTo("Frankie Conner Ritter"));
            Assert.That(fullNames[10].ToString(), Is.EqualTo("Shelby Nathan Yoder"));
        }

        [Test]
        public void SortNamesWithSameLastNameTest()
        {
            List<FullName> fullNames =
            [
                new FullName("Beau", "Bentley"),
                new FullName("Adam", "Bentley"),
                new FullName("Shelby", "Yoder"),
                new FullName("Adonis", "Archer"),
            ];

            fullNames = Sorter.SortNames(fullNames);

            Assert.That(fullNames[0].ToString(), Is.EqualTo("Adonis Archer"));
            Assert.That(fullNames[1].ToString(), Is.EqualTo("Adam Bentley"));
            Assert.That(fullNames[2].ToString(), Is.EqualTo("Beau Bentley"));
            Assert.That(fullNames[3].ToString(), Is.EqualTo("Shelby Yoder"));
        }

        [Test]
        public void SortNamesWithDuplicatesTest()
        {
            List<FullName> fullNames =
            [
                new FullName("Adam", "Bentley"),
                new FullName("Shelby", "Yoder"),
                new FullName("Adam", "Bentley"),
                new FullName("Adonis", "Archer"),
                new FullName("Adam", "Bentley"),
            ];

            fullNames = Sorter.SortNames(fullNames);

            Assert.That(fullNames[0].ToString(), Is.EqualTo("Adonis Archer"));
            Assert.That(fullNames[1].ToString(), Is.EqualTo("Adam Bentley"));
            Assert.That(fullNames[2].ToString(), Is.EqualTo("Adam Bentley"));
            Assert.That(fullNames[3].ToString(), Is.EqualTo("Adam Bentley"));
            Assert.That(fullNames[4].ToString(), Is.EqualTo("Shelby Yoder"));
        }
    }
}