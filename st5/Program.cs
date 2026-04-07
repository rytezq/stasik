                              using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Player[] pp = new Player[4];

            pp[0] = new Player("a");
            pp[1] = new Player("b");
            pp[2] = new Player("c");
            pp[3] = new Player("d");

            for (int i = 0; i < pp.Length; i++)
            {
                Console.WriteLine($"Игрок {i + 1}");
                Console.WriteLine($"Хотите ввести очки самостоятельно или рандомно (1/2)");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine($"Введите число очков");
                    int b = Convert.ToInt32(Console.ReadLine());
                    pp[i].AddPoits(b);
                }
                else if (a == 2)
                {
                    Console.WriteLine($"Рандомное число очков");
                    int c = r.Next(0, 101);
                    pp[i].AddPoits(c);
                }

                pp[i].PrintInfo();
                pp[i].CheckRecord();
            }

            Player.PrintRecord();
        }
    }
    class Player
    {
        public string Name;
        public int Score;
        private static int HighScore;
        private static string RecordHolder;
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public void AddPoits(int points)
        {
            Console.WriteLine($"Зачисление очков");
            Score += points;
            Console.WriteLine($"Очки зачислены");
        }
        public void CheckRecord()
        {
            Console.WriteLine($"Проверка рекорда");
            if (Score >= HighScore)
            {
                Console.WriteLine($"Рекорд побит");
                HighScore = Score;
                RecordHolder = Name;
            }
            else
            {
                Console.WriteLine($"Рекорд не побит");
            }
        }
        public static void PrintRecord()
        {
            Console.WriteLine($"Имя рекордсмена - {RecordHolder}, Рекорд - {HighScore}");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Игрок - {Name}, счет - {Score}");
        }
    }
}
