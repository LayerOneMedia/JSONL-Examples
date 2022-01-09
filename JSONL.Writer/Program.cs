using JSONL.Writer.Utility;
using System.Text.Json;

var directoryPath = Path.Join(
        "\\",
        "temp",
        "JSONL-Example");
Directory.CreateDirectory(directoryPath);   

var people = PersonUtility.GetRandomPeople(10);

using (var writer = File.CreateText(Path.Join(directoryPath, $"People-{DateTime.Now.ToFileTimeUtc()}.jsonl")))
{
    foreach (var person in people)
    {
        writer.WriteLine(JsonSerializer.Serialize(person));
    }
}
