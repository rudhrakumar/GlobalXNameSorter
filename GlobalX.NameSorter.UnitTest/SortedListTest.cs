using GlobalX.NameSorter.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GlobalX.NameSorter.UnitTest
{
    public class SortedListTest
    {
        
        [Fact]
        public void personSortHelperTest_Person1lastNameComesFirst()
        {
            var unsortedList = new List<Person>();
            
            var person1 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            var person2 = new Person() { FirstName = "Alpha", LastName = "Gama" };
            unsortedList.Add(person1);
            unsortedList.Add(person2);
            unsortedList.Sort(new PersonSortHelper());
            
            Assert.Equal(unsortedList[0].FirstName, person1.FirstName);
            Assert.Equal(unsortedList[0].LastName, person1.LastName);
            Assert.Equal(unsortedList[1].FirstName, person2.FirstName);
            Assert.Equal(unsortedList[1].LastName, person2.LastName);
            
        }
        [Fact]
        public void personSortHelperTest_Person2lastNameComesFirst()
        {
            var unsortedList = new List<Person>();

            var person1 = new Person() { FirstName = "Alpha", LastName = "Gama" };
            var person2 = new Person() { FirstName = "Alpha", LastName = "Beta" };
            unsortedList.Add(person1);
            unsortedList.Add(person2);
            unsortedList.Sort(new PersonSortHelper());

            Assert.Equal(unsortedList[0].FirstName, person2.FirstName);
            Assert.Equal(unsortedList[0].LastName, person2.LastName);
            Assert.Equal(unsortedList[1].FirstName, person1.FirstName);
            Assert.Equal(unsortedList[1].LastName, person1.LastName);

        }
    }
}
