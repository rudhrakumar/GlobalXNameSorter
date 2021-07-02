using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GlobalX.NameSorter
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
