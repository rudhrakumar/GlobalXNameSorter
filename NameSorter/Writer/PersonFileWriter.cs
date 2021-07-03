using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GlobalX.NameSorter.Writer
{
    /// <summary>
    /// Writes the list of person provided to 
    /// the file. File name is passed in the constructor
    /// </summary>
    class PersonFileWriter : IDataWriter
    {
        private string outputFileName { get; set; }
        public PersonFileWriter(string outputFileName)
        {
            this.outputFileName = outputFileName;
        }
        public void Save(List<Person> personList)
        {
            // Write each person name to a file.
            using (StreamWriter sw = new StreamWriter(outputFileName, false))
            {
                foreach (var person in personList)
                {
                    sw.WriteLine(person.ToString());
                }
            }
        }
    }
}
