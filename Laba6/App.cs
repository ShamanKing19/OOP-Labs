namespace Laba6
{
    public static class Laba6
    {
        public static void Main()
        {
            // TaskA(); // Метод расширения
            TaskB(); // Многопоточность и события
        }


        private static void TaskB()
        {
            EventGenerator eventGenerator = new EventGenerator(3);

            Thread thread = new Thread(() =>
            {
                eventGenerator.GenerateEvent(100, 1000);
            });
            
            eventGenerator.SomeEvent += EventHandler1;
            eventGenerator.SomeEvent += EventHandler2;
            eventGenerator.SomeEvent += EventHandler3;
            eventGenerator.SomeEvent += EventHandler4;
            eventGenerator.SomeEvent += EventHandler5;
            eventGenerator.SomeEvent += EventHandler6;
            
            thread.Start();
            
            Thread.Sleep(5000);
            eventGenerator.SomeEvent -= EventHandler1;
            eventGenerator.SomeEvent -= EventHandler2;
            Console.WriteLine("Слушатель 1 и 2 должны были отписаться");

            Thread.Sleep(5000);
            eventGenerator.SomeEvent += EventHandler1;
            eventGenerator.SomeEvent += EventHandler2;
            eventGenerator.SomeEvent -= EventHandler3;
            eventGenerator.SomeEvent -= EventHandler4;
            Console.WriteLine("Уже слушатели 3 и 4 должны были отписаться");
            
            Thread.Sleep(5000);
            eventGenerator.SomeEvent -= EventHandler5;
            eventGenerator.SomeEvent -= EventHandler6;
            Console.WriteLine("Вот это да... Слушатели 5 и 6 тоже отписались :(");
        }
        
        private static void EventHandler1()
        {
            Console.WriteLine("Слушатель 1");

        }
        
        private static void EventHandler2()
        {
            Console.WriteLine("Слушатель 2");

        }
        
        private static void EventHandler3()
        {
            Console.WriteLine("Слушатель 3");

        }
        
        private static void EventHandler4()
        {
            Console.WriteLine("Слушатель 4");

        }
        
        private static void EventHandler5()
        {
            Console.WriteLine("Слушатель 5");

        }
        
        private static void EventHandler6()
        {
            Console.WriteLine("Слушатель 6");

        }
        
        
        private static void TaskA()
        {
            int[] intArray = new[] { 12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Predicate<int> isEven = (int number) => number % 2 == 0;
            int[] filteredArray = intArray.CustomFilter(isEven, false);

            foreach (int item in filteredArray) {
                Console.WriteLine(item);
            }

            string[] stringArray = new[] {"one", "two", "three", "four", "five"};
            string[] evenStringsArray = new[] { "two", "four" };
            Predicate<string> isEvenString = (string item) => evenStringsArray.Contains(item);
            string[] filteredStringArray = stringArray.CustomFilter(isEvenString);

            foreach (string item in filteredStringArray) {
                Console.WriteLine(item);
            }
        }
    
    }    
    
    
}
