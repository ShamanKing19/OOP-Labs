namespace Laba5
{
    public class App
    {
        public static void Main()
        {
            
            // SomeClass instanceForJson = new SomeClass("qwe", "zxc", 3546);
            // Json jsonSerializer = new Json("json");
            // jsonSerializer.Write("objectInstanceJson", instanceForJson);
            // SomeClass someInstance = jsonSerializer.Read("objectInstanceJson");
            // Console.WriteLine(someInstance);
            // Console.ReadKey();

            // SomeClass instanceForXml = new SomeClass("xml", "hkjashdkjlashd", 1241);
            // Xml xmlSerializer = new Xml("xml");
            // xmlSerializer.Write("instanceForXml", instanceForXml);
            // SomeClass someClassInstance = xmlSerializer.Read("objectInstanceXml");
            // Console.WriteLine(someClassInstance);
            // Console.ReadKey();


            // SomeClass instanceForBinary = new SomeClass("Binary", "010101", 101);
            Binary binarySerializer = new Binary("Binary");
            // binarySerializer.Write("instanceForBinary", instanceForBinary);
            SomeClass someClassInstance = binarySerializer.Read("instanceForBinary");
            Console.WriteLine(someClassInstance);
            Console.ReadKey();

        }
    }
}
