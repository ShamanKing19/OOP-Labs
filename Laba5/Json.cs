using System.Text;
using System.Text.Json;

namespace Laba5;

public class Json : ISettingsService<SomeClass>
{
    public string WorkdirName { get; set; }

    
    public SomeClass Read(string filename)
    {
        try
        {
            string text = File.ReadAllText($"./{WorkdirName}/{filename}.json");
            SomeClass someClassInstance = JsonSerializer.Deserialize<SomeClass>(text);
            return someClassInstance;
        }
        catch
        {
            return new SomeClass();
        }
    }
    

    public void Update(SomeClass item)
    {
    }
    

    public void Write(string filename, object data)
    {
        if (!Directory.Exists(this.WorkdirName)) {
            Directory.CreateDirectory(this.WorkdirName);
        }

        try
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText($"./{WorkdirName}/{filename}.json", json);
        }
        catch
        {
            Console.WriteLine($"Ошибка при записи файла");
            Console.WriteLine(data);
        }
    }

    public Json(string workdirName)
    {
        WorkdirName = workdirName;
    }
}