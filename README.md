# Read and Write Files

## Reading Files

### Using OpenText

This method uses the StreamReader class and its ReadLine method

```c#
using (StreamReader sr = File.OpenText(path))
{
  string line;
  while ((line = sr.ReadLine()) != null) // Assign new line to variable
      Console.WriteLine(line); // Print read line
}
```

### Using ReadAllText

As its name says, the ReadAllText method returns a string containing the file's content

```c#
string path = "read.txt";
string content = File.ReadAllText(path);
  Console.WriteLine(content);
```

### Using ReadAllLines

The ReadAllLines method is very similar to the ReadAllText one except it returns
an array of string where each element represents a line of the file read.

```c#
string[] lines = File.ReadAllLines(path);
foreach (string line in lines)
    Console.WriteLine(line);
```

## Writing to Files

### Using CreateText

This method uses the StreamWriter class and its WriteLine method

```c#
string path = "write.txt";
using (StreamWriter sw = File.CreateText(path))
  {
    // Write content using StreamWriter object
    sw.WriteLine("First line");
    sw.WriteLine("Second line");
    sw.WriteLine("Third line");
  }
```

### Using AppendToFile

The AppendToFile method takes the data to add as a string and
appends it at the end of the file

```c#
using (StreamWriter sw = File.AppendText(path))
{
    // Write content using StreamWriter object
    sw.WriteLine("Using AppendText method");
    sw.WriteLine("We use the StreamWriter object");
}
```

## Resources

[File Class - Microsoft docs](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-5.0)
