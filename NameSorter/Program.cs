using GlobalX.NameSorter;
using GlobalX.NameSorter.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GlobalX.NameSorter.Writer;
using System.Reflection;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        string inputFile = "";
        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        var basePath = Path.GetDirectoryName(path);
        if (args.Length == 0)
        {
            inputFile = $"{basePath}\\unsorted-names-list.txt";
        }
        else
        {
            inputFile = $"{basePath}\\{args[0]}";
        }
        // read the file and sort the names
        PersonFileReader fileReader = new PersonFileReader();
        List<Person> nameList =  fileReader.ReadUnSortedNameFile(inputFile);
        nameList.Sort(new PersonSortHelper());
        nameList.ForEach(x =>
        {
            Console.WriteLine(x.ToString());
        });
        // Write to file
        IDataWriter fileWriter = new PersonFileWriter($"{basePath}\\sorted-names-list.txt");
        fileWriter.Save(nameList);
    }

}