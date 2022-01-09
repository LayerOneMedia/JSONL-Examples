using JSONL.Model;
using System.Text;
using System.Text.Json;

var directoryPath = Path.Join(
        "\\",
        "temp",
        "JSONL-Example");

var file = Directory.EnumerateFiles(directoryPath).First();

var people = new List<Person>();

using (var stream = new StreamReader(file, Encoding.UTF8))
{
    while (!stream.EndOfStream)
    {
        var jsonLine = stream.ReadLine();
        var person = JsonSerializer.Deserialize<Person>(jsonLine ?? String.Empty);
        if(person != null) people.Add(person);
    }  
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Total count of parsed objects : {people.Count}");
Console.ResetColor();