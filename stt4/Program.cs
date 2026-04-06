using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("Хлеб", 50, 10);
            Product milk = new Product("Молоко", 80, 5);
            Product cheese = new Product("Сыр", 200, 3);

            bread.Printinfo();
            milk.Printinfo();
            cheese.Printinfo();

            Console.WriteLine("Сколько продать хлеба?");
            int breadCount = int.Parse(Console.ReadLine());
            bread.Sell(breadCount);
            Console.WriteLine($"Текущая выручка {Product.GetTotalRevenue()}");

            Console.WriteLine("Сколько продать молока?");
            int milkCount = int.Parse(Console.ReadLine());
            milk.Sell(milkCount);
            Console.WriteLine($"Текущая выручка {Product.GetTotalRevenue()}");

            Console.WriteLine("Сколько продать сыра?");
            int cheeseCount = int.Parse(Console.ReadLine());
            cheese.Sell(cheeseCount);
            Console.WriteLine($"Текущая выручка {Product.GetTotalRevenue()}");

            Console.WriteLine("Остатки товаров");
            bread.Printinfo();
            milk.Printinfo();
            cheese.Printinfo();

            Console.WriteLine($"Итоговая выручка {Product.GetTotalRevenue()}");
        }
    }
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        private static double totalRevenue = 0;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Sell(int soldCount)
        {
            if (soldCount <= Quantity)
            {
                totalRevenue = soldCount * Price;
                Quantity = Quantity - soldCount;
                Console.WriteLine($"Продано {soldCount} штук товара {Name} за {totalRevenue}");
            }
            else
            {
                Console.WriteLine("Недостаточно товара");
            }
        }
        public static double GetTotalRevenue()
        {
            return totalRevenue;
        }
        public static void ResetRevenue()
        {
            totalRevenue = 0;
            Console.WriteLine("Выручка обнулена");
        }
        public  void Printinfo()
        {
            Console.WriteLine($" Товар {Name} с ценой {Price} в наличии {Quantity} шт.");
        }
    }
}
