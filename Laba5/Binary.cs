using System.Runtime.Serialization.Formatters.Binary;

namespace Laba5;

public class Binary : ISettingsService<SomeClass>
{
   public string WorkdirName { get; set; }

   
   public Binary(string workdirName)
   {
       WorkdirName = workdirName;
       if (!Directory.Exists(workdirName)) {
           Directory.CreateDirectory(workdirName);
       }
   }

   [Obsolete("Obsolete")]
   public SomeClass Read(string filename)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fs = new FileStream($"./{WorkdirName}/{filename}.dat", FileMode.OpenOrCreate))
        {
            SomeClass someClassInstance = (SomeClass)formatter.Deserialize(fs);
            return someClassInstance;
        }
        
    }

    public void Update(SomeClass item)
    {
    }

    [Obsolete("Obsolete")]
    public void Write(string filename, object data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream($"{WorkdirName}/{filename}.dat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, data);
        }
    }
}