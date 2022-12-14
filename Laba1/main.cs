using System;

namespace Laba1
{
    class Laba1
    {
        static void Main(string[] args)
        {

            string result = ReadUserInput(
                "имя",
                "Введите",
                "не может быть пустым",
                "должно быть не длиннее",
                10 
             );

            int intResult = GiveMeSomeNumbers(
                "возраст",
                "Введите свой",
                "у вас слишком большой или слишком маленький",
                3,
                100
            );


            float floatResult = GiveMeSomeFloatNumbers(
                "вес",
                "Введите свой",
                "у вас слишком большой или слишком маленький",
                50,
                120
            );
        }


        public static string ReadUserInput(
            string fieldName,
            string question = "Стандартный вопрос",
            string answerIfEmpty = "не может быть пустыыыыым",
            string answerIfLong = "не может быть длиннее",
            int maxLength = 10
        ) {
            string capitalizedWord = fieldName.Substring(0, 1).ToUpper() + fieldName.Substring(1);

            Console.WriteLine(question + " " + fieldName);

            string input = "";
            while (input.Length > maxLength || input.Length == 0)
            {
                input = Console.ReadLine();
                if (input.Length == 0) {
                    Console.WriteLine(capitalizedWord + " " + answerIfEmpty);
                } else if (input.Length > maxLength) {
                    Console.WriteLine(capitalizedWord + " " + answerIfLong + " " + maxLength + " символов");
                }
            }
            
            return input;
        }


        public static int GiveMeSomeNumbers(
            string fieldName,
            string question = "Стандартный вопрос",
            string answerIfOutOfRange = "не попадает в диапазон",
            int minValue = 0,
            int maxValue = 10
        ) {
            string capitalizedWord = fieldName.Substring(0, 1).ToUpper() + fieldName.Substring(1);
            Console.WriteLine(question + " " + fieldName);
            
            while (true)
            {
                string userStupidInput = Console.ReadLine(); // Слишком большое число в строку преобразует

                if (int.TryParse(userStupidInput, out int input))
                {
                    if (input < minValue || input > maxValue)
                    {
                        Console.WriteLine($"{capitalizedWord} {answerIfOutOfRange}");
                    } else {
                        return input;
                    }

                } else {
                    Console.WriteLine($"{question} {fieldName}");
                }

            };
        }


        public static float GiveMeSomeFloatNumbers(
            string fieldName,
            string question = "Стандартный вопрос",
            string answerIfOutOfRange = "не попадает в диапазон",
            int minValue = 0,
            int maxValue = 10
        )
        {
            string capitalizedWord = fieldName.Substring(0, 1).ToUpper() + fieldName.Substring(1);
            Console.WriteLine(question + " " + fieldName);

            while (true) 
            {
                string userStupidInput = Console.ReadLine();

                if (float.TryParse(userStupidInput, out float input))
                {
                    if (input < minValue || input > maxValue) {
                        Console.WriteLine($"{capitalizedWord} {answerIfOutOfRange}");
                    } else {
                        return input;
                    }

                } else {
                    Console.WriteLine($"{question} {fieldName}");
                }

            }
        }

    }
}
