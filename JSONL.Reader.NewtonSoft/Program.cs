using JSONL.Model;
using Newtonsoft.Json;
using System.Text;


var directoryPath = Path.Join(
        "\\",
        "temp",
        "JSONL-Example");

var file = Directory.EnumerateFiles(directoryPath).First();

var people = new List<Person>();

using (var stream = new StreamReader(file, Encoding.UTF8))
using (var reader = new JsonTextReader(stream))
{
    reader.SupportMultipleContent = true;
    var serializer = JsonSerializer.Create();

    while (reader.Read())
    {
        var person = serializer.Deserialize<Person>(reader);
        if (person != null) people.Add(person);
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Total count of parsed objects : {people.Count}");
Console.ResetColor();