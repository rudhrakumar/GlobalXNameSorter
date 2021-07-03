using GlobalX.NameSorter.Utils;
using System;
using Xunit;

namespace GlobalX.NameSorter.UnitTest
{
    /// <summary>
    /// Unit test to validate the PersonSortHelper class functionality
    /// </summary>
    public class PersonSortHelperTest
    {
        /// <summary>
        /// Test cases to compare two names are sorted correctly
        /// </summary>
        PersonSortHelper sorthelper = new PersonSortHelper();
        [Fact]
        public void personSortHelperTest_Person1lastNameComesFirst()
        {
            // Set up test data and test the result
            var person1 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            var person2 = new Person() { FirstName = "Alpha", LastName = "Gama" };
            var result = sorthelper.Compare(person1, person2);
            Assert.Equal(-1, result);
        }
        [Fact]
        public void personSortHelperTest_Person1lastNameComesSecond()
        {
            var person1 = new Person() { FirstName = "Alpha", LastName = "Gama" };
            var person2 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            var result = sorthelper.Compare(person1, person2);
            Assert.Equal(1, result);
        }
        [Fact]
        public void personSortHelperTest_PersonNamesAreSame()
        {
            var person1 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            var person2 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            var result = sorthelper.Compare(person1, person2);
            Assert.Equal(0, result);
        }
    }
}
