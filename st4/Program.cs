using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("Хлуб", 50, 67);
            Product milk = new Product("Молоко", 80, 52);
            Product chees = new Product("Сыр", 200, 67);

            int a = 0;
            while (a != 5)
            {
                Console.WriteLine($"1. Хлеб");
                Console.WriteLine($"2. Молоко");
                Console.WriteLine($"3. Сыр");
                Console.WriteLine($"4. Показать информацию о товарах");
                Console.WriteLine($"5. Закритие смены");
                a = Convert.ToInt32(Console.ReadLine());
                int b = 0;
                switch (a)
                {
                    case 1:
                        Console.WriteLine($"Введите количество товаров предаставленные на покупку");
                        b = Convert.ToInt32(Console.ReadLine());
                        bread.Sell(b);
                        Product.GetTotalRevenue();
                        break;
                    case 2:
                        Console.WriteLine($"Введите количество товаров предаставленные на покупку");
                        b = Convert.ToInt32(Console.ReadLine());
                        milk.Sell(b);
                        Product.GetTotalRevenue();
                        break;
                    case 3:
                        Console.WriteLine($"Введите количество товаров предаставленные на покупку");
                        b = Convert.ToInt32(Console.ReadLine());
                        chees.Sell(b);
                        Product.GetTotalRevenue();
                        break;
                    case 4:
                        bread.PrintInfo();
                        milk.PrintInfo();
                        chees.PrintInfo();
                        Product.GetTotalRevenue();
                        break;
                    case 5:
                        Console.WriteLine($"Закрытие смены");
                        Product.GetTotalRevenue();
                        Product.ResetRevenue();
                        break;
                    default:
                        Console.WriteLine($"Неверный ввод, повторите попытку");
                        break;
                }
            }
        }
    }
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public static double totalRevenue;
        public Product(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }
        public void Sell(int soldCount)
        {
            if (soldCount <= Quantity)
            {
                totalRevenue += soldCount * Price;
                Quantity -= soldCount;
                Console.WriteLine($"Было проданно {soldCount} за {soldCount * Price} руб.");
            }
            else
            {
                Console.WriteLine($"Недастаточно товара для продажи, повторите попытку.");
            }
        }
        public static void GetTotalRevenue()
        {
            Console.WriteLine($"Общая выручка составляет {totalRevenue} руб.");
        }
        public static void ResetRevenue()
        {
            totalRevenue = 0;
            Console.WriteLine($"Общая выручка была обнулина");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Наименование: {Name}, Цена: {Price}, Количество: {Quantity}");
        }
    }
}
