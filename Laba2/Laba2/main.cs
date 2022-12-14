using System;

namespace Laba2
{
    public static class Laba2
    {
        static string brick = "#";
        static double aspectRatio = 16f / 9f;

        static void Main(string[] args)
        {
            PrintHouse(30, 30, Color.Blue, Color.Red, Color.Magenta, Color.Cyan);
            Console.ReadKey();
        }


        public static void PrintHouse(int startX, int startY, Color houseBodyColor, Color doorColor, Color windowColor, Color pipeColor)
        {
            startX = (int)(startX * aspectRatio);

            int floorWidth = 20;
            int wallHeight = 20;

            int doorWidth = 5;
            int doorHeight = 10;

            int windowWidth = 5;
            int windowHeight = 5;

            int pipeWidth = 3;
            int pipeHeight = 4;

            printLineX(startX, startX + floorWidth, startY, houseBodyColor); // Потолок
            printLineX(startX, startX + floorWidth, startY + wallHeight, houseBodyColor);  // Пол
            printLineY(startY, startY + wallHeight, startX, houseBodyColor); // Левая стена 
            printLineY(startY, startY + wallHeight + 1, startX + floorWidth, houseBodyColor); // Правая стена 

            // Дверь
            int doorStartX = startX + 3;
            int doorStartY = startY + 10;
            printLineX(doorStartX, doorStartX + doorWidth, doorStartY, doorColor);
            printLineY(doorStartY, doorStartY + doorHeight, doorStartX, doorColor);
            printLineY(doorStartY, doorStartY + doorHeight, doorStartX + doorWidth, doorColor);

            // Окно
            int windowStartX = startX + 12;
            int windowStartY = startY + 3;
            printLineX(windowStartX, windowStartX + windowWidth, windowStartY, windowColor);
            printLineX(windowStartX, windowStartX + windowWidth, windowStartY + windowHeight, windowColor);
            printLineY(windowStartY, windowStartY + windowHeight, windowStartX, windowColor);
            printLineY(windowStartY, windowStartY + windowHeight + 1, windowStartX + windowWidth, windowColor);

            // Труба
            int startPipeX = startX + 3;
            int startPipeY = startY - 4;
            printLineX(startPipeX, startPipeX + pipeWidth, startPipeY, pipeColor);
            printLineY(startPipeY, startPipeY + pipeHeight, startPipeX, pipeColor);
            printLineY(startPipeY, startPipeY + pipeHeight, startPipeX + pipeWidth, pipeColor);

        }


        static void printLineX(int startX, int endX, int y, Color color = Color.White)
        {
            setConsoleColor(color);

            startX = (int)(startX * aspectRatio);
            endX = (int)(endX * aspectRatio);

            for (int x = startX; x < endX; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(brick);
            }
        }

        static void printLineY(int startY, int endY, int x, Color color = Color.White)
        {
            setConsoleColor(color);

            x = (int)(x * aspectRatio);

            for (int y = startY; y < endY; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(brick);
            }
        }


        static void setConsoleColor(Color color)
        {
            switch (color)
            {
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case Color.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }


    }


    public enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Magenta,
        Cyan
    }

}
