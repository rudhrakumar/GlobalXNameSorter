using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalX.NameSorter
{
    /// <summary>
    /// Interface to save the processed data from the list
    /// </summary>
    interface IDataWriter
    {
        public void Save(List<Person> personList);
    }
}
