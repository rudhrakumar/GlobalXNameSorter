using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GlobalX.NameSorter.Utils
{
    public class PersonSortHelper : IComparer<Person>
    {
        // copmare person objects to sort based on last name
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            // return String.Compare(x.LastName, y.LastName)*-1; descending order
            return String.Compare(x.LastName, y.LastName);
        }
    }
}
