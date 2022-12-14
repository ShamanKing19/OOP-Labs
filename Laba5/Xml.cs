using System.Xml.Serialization;

namespace Laba5;

public class Xml : ISettingsService<SomeClass>
{
    public string WorkdirName { get; set; }

    
    public Xml(string workdirName)
    {
        WorkdirName = workdirName;
        if (!Directory.Exists(workdirName)) {
            Directory.CreateDirectory(workdirName);
        }
    }
    
    
    public SomeClass Read(string filename)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(SomeClass));
        using (FileStream fs = new FileStream($"./{WorkdirName}/{filename}.xml", FileMode.OpenOrCreate))
        {
            SomeClass? someClassInstance = xmlSerializer.Deserialize(fs) as SomeClass;
            return someClassInstance;
        }
    }

    public void Update(SomeClass item)
    {
    }

    public void Write(string filename, object data)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(SomeClass));
        using (FileStream fs = new FileStream($"./{WorkdirName}/{filename}.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, data);
        }
        
    }
    
    
}