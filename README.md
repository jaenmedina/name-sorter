# Name Sorter

A project that sorts a list of names. Given a set of names, it orders that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Installing

If you don't have it installed already you should download [.NET core](https://www.microsoft.com/net/download/core "Download .NET core").

Once this is done you can pick whatever development environment you'd prefer. I used Visual Studio, but you could just as easily use the command line or Visual Studio Code.

The publish step will vary depending on your operating system. Once this is complete you can navigate to the program name-sorter in 
```
NameSorter\NameSorter\bin\Debug\net8.0
```
 or similar, paste the file you want to sort into the same directory, and run the .exe

```
C:\Example>NameSorter.exe ./unsorted-names-list.txt ./sorted-names-list.txt
```

## Built With

* [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/ ".NET Core docs") - The framework used
* [Visual Studio](https://visualstudio.microsoft.com/vs/ "VS docs") - Development environment

## Authors

* **Jaen Medina** - [jaenmedina](https://github.com/jaenmedina)