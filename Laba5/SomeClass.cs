namespace Laba5;

[Serializable] // Для бинарной сериализации
public class SomeClass
{
    public string Field1 { get; set; }
    public string Field2 { get; set; }
    public int Field3 { get; set; }


    public SomeClass()
    {
        
    }
    
    public SomeClass(string field1, string field2, int field3)
    {
        Field1 = field1;
        Field2 = field2;
        Field3 = field3;
    }

    public override string ToString()
    {
        return $"SomeClass instance with values {Field1}, {Field2}, {Field3}";
    }
}