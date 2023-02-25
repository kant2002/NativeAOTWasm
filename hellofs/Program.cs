using System.Net.Http;

Directory.CreateDirectory("test");
Console.WriteLine("Database test created!");
File.WriteAllText("test/myfile.txt", "This is some text");
Console.WriteLine("File test/myfile.txt written!");
var content = File.ReadAllText("test/myfile.txt");
Console.WriteLine("File test/myfile.txt read!");
Console.WriteLine(content);
