using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GlobalX.NameSorter.Utils
{
    class PersonFileReader
    {
        /// <summary>
        /// Read the file and create a list of person object and return to the caller
        /// </summary>
        /// <param name="fileName"> Input file name</param>
        /// <returns>List of person objects</returns>
        public List<Person> ReadUnSortedNameFile (string fileName){
            List<Person> unsortedNamesList = new List<Person>();
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;
                        // Read and display lines from the file until the end of
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] words = line?.Split(' ');
                            if (words?.Length > 0)
                            {
                                // Exclude the last item from the name string using linq query
                                var firstName = string.Join(" ", (words.Take(words.Length - 1))).ToString(); 
                                var lastName = words.Last().ToString();
                                unsortedNamesList.Add(new Person
                                {
                                    FirstName = firstName,
                                    LastName = lastName
                                }); 
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
            return unsortedNamesList;
        }
    }
}
