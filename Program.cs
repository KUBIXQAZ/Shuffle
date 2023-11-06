using System;

namespace Shuffle
{
    internal class Program
    {
        static void basicShuffle(string[] list)
        {
            Console.WriteLine("OLD LIST -->");
            foreach (string element in list)
            {
                Console.Write($"{element} ");
            }
            Random random = new Random();

            for (int i = 0; i < list.Length; i++)
            {
                int nextPos = -1;
                while (nextPos == i || nextPos < 0)
                {
                    nextPos = random.Next(0, list.Length);
                }

                string hold = list[nextPos];
                list[nextPos] = list[i];
                list[i] = hold;
            }

            Console.WriteLine("\n\nNEW LIST -->");
            foreach (string element in list)
            {
                Console.Write($"{element} ");
            }
        }

        static void randomShuffle(string[] list)
        {
            Console.WriteLine("OLD LIST -->");
            foreach (string element in list)
            {
                Console.Write($"{element} ");
            }

            Random random = new Random();

            string[] shuffledList = new string[list.Length];
            bool[] used = new bool[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                int nextPos = -1;
                while (nextPos == -1 || used[nextPos])
                {
                    nextPos = random.Next(0, list.Length);
                }
                used[nextPos] = true;
                shuffledList[nextPos] = list[i];
            }

            Console.WriteLine("\n\nNEW LIST -->");
            foreach (string element in shuffledList)
            {
                Console.Write($"{element} ");
            }
        }

        static void Main(string[] args)
        {
            string[] list = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            Console.WriteLine("BASIC SHUFFLE (SWAP) -->");
            basicShuffle(list);

            Console.WriteLine("\n\n====================\n");

            Console.WriteLine("RANDOM SHUFFLE (RANDOM) -->");
            randomShuffle(list);

            Console.ReadKey();
        }
    }
}
