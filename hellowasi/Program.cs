Console.WriteLine("Hello, WASM! Don't forget to add --mapdir .:.  when run wasmer");
Directory.CreateDirectory("test");
Console.WriteLine("Database test created!");
File.WriteAllText("test/myfile.txt", "This is some text");
Console.WriteLine("File test/myfile.txt written!");
var content = File.ReadAllText("test/myfile.txt");
Console.WriteLine("File test/myfile.txt read!");
Console.WriteLine(content);
Console.WriteLine("We are done here!");