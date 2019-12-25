using System;

namespace RandomCube
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                DrawCube(GetRandomNumber());
                Console.ReadKey();
            }
        }

        static void DrawCube(int number)
        {
            switch(number)
            {
                case 1:
                    Console.Write("=========\n" +
                                  "|       |\n" +
                                  "|   0   |\n" +
                                  "|       |\n" +
                                  "=========\n");
                    break;

                case 2:
                    Console.Write("=========\n" +
                                  "|       |\n" +
                                  "| 0   0 |\n" +
                                  "|       |\n" +
                                  "=========");
                    break;

                case 3:
                    Console.Write("=========\n" +
                                  "|       |\n" +
                                  "| 0 0 0 |\n" +
                                  "|       |\n" +
                                  "=========\n");
                    break;

                case 4:
                    Console.Write("=========\n" +
                                  "| 0   0 |\n" +
                                  "|       |\n" +
                                  "| 0   0 |\n" +
                                  "=========\n");
                    break;

                case 5:
                    Console.Write("=========\n" +
                                  "| 0   0 |\n" +
                                  "|   0   |\n" +
                                  "| 0   0 |\n" +
                                  "=========\n");

                    break;

                case 6:
                    Console.Write("=========\n" +
                                  "| 0 0 0 |\n" +
                                  "| 0 0 0 |\n" +
                                  "| 0 0 0 |\n" +
                                  "=========\n");

                    break;
            }
        }

        static int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
