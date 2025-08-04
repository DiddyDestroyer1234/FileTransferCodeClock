using System.IO;  // include the System.IO namespace
string path = @"C:\C# Test";
public static System.IO.DirectoryInfo CreateDirectory(string path);
string writeText = "Hello World!";// Create a text string
File.WriteAllText(path "filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content