# GlobalX Name Sorter
Name sorter application
# The Goal: Name Sorter
Build a name sorter. Given a set of names, order that set first by last name, then by any given names the person may have. A
name must have at least 1 given name and may have up to 3 given names.
# Sample Data
  Janet Parsons<br/>
  Vaughn Lewis<br/>
  Adonis Julius Archer<br/>
  Shelby Nathan Yoder<br/>
  Marin Alvarez<br/>
  London Lindsey<br/>
  Beau Tristan Bentley<br/>
  Leo Gardner<br/>
  Hunter Uriah Mathew Clarke<br/>
  Mikayla Lopez<br/>
  Frankie Conner Ritter<br/>

# Execution
Load the file into the working directory and execute command
name-sorter ./unsorted-names-list.txt

Result is saved in the tesxt file sorted-names-list.txt

# Application
This is a .Net Core console application written in C#
Application read the given file and sort the last name by comparing objects using IComparer.
Sorted result is saved in a file in the working directory called sorted-names-list.txt

# Unit Test
XUnit test project runs few test cases to validate the PersonSorter class 
and a list of names are sorted in the correct order.


