using GlobalX.NameSorter;
using GlobalX.NameSorter.Utils;
using System;
using System.Collections.Generic;
using GlobalX.NameSorter.Writer;
using System.Reflection;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "";
        //Find the executing assembly path
        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        var basePath = Path.GetDirectoryName(path);
        // If there is no filename passed in the arguement use the default file
        if (args.Length == 0)
        {
            inputFile = $"{basePath}\\unsorted-names-list.txt";
        }
        else
        {
            inputFile = $"{basePath}\\{args[0]}";
        }
        // Read the file and sort the names
        PersonFileReader fileReader = new PersonFileReader();
        List<Person> nameList =  fileReader.ReadUnSortedNameFile(inputFile);
        nameList.Sort(new PersonSortHelper());
        nameList.ForEach(x =>
        {
            Console.WriteLine(x.ToString());
        });
        // Write to file named sorted-names-list.txt
        IDataWriter fileWriter = new PersonFileWriter($"{basePath}\\sorted-names-list.txt");
        fileWriter.Save(nameList);
    }
}