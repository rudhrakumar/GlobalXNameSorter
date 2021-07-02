using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX.NameSorter
{
    interface IDataWriter
    {
        public void Save(List<Person> personList);
    }
}
