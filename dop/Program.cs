using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder.SetShopName("Додо Пицца");
            PizzaOrder.SetDiscount(10);

            Console.WriteLine($"Название пиццерии: {PizzaOrder.shopName}");
            Console.WriteLine($"Текущая скидка: {PizzaOrder.discountPercent}%");
            Console.WriteLine();

            PizzaOrder order1 = new PizzaOrder();
            order1.PizzaName = "Маргарита";
            order1.Quantity = 2;
            order1.PricePerPizza = 500;

            Console.WriteLine("Заказ #1:");
            order1.ProcessOrder();
            Console.WriteLine();

            PizzaOrder order2 = new PizzaOrder("Пепперони", 1, 600);

            Console.WriteLine("Заказ #2:");
            order2.ProcessOrder();
            Console.WriteLine();

            Console.WriteLine("Статистика пиццерии:");
            PizzaOrder.PrintStatistics();
            Console.WriteLine();

            Console.WriteLine("«««Меняем скидку на 20%»»»");
            PizzaOrder.SetDiscount(20);
            Console.WriteLine();

            PizzaOrder order3 = new PizzaOrder("Гавайская", 3, 550);

            Console.WriteLine("Заказ #3:");
            order3.ProcessOrder();
            Console.WriteLine();

            Console.WriteLine("Итоговая статистика:");
            PizzaOrder.PrintStatistics();

            Console.WriteLine();
        }
    }
    class PizzaOrder
    {

        public string PizzaName;
        public int Quantity;
        public double PricePerPizza;
  
        public static double totalRevenue = 0;
        public static int totalPizzasSold = 0;
        public static string shopName = "Нету";
        public static double discountPercent = 0;

        public PizzaOrder()
        {
            PizzaName = "Неизвестно";
            Quantity = 1;
            PricePerPizza = 0;
        }

        public PizzaOrder(string pizzaName, int quantity, double pricePerPizza) : this()
        {
            this.PizzaName = pizzaName;
            this.Quantity = quantity;
            this.PricePerPizza = pricePerPizza;
        }

        public double CalculateTotalPrice()
        {
            return Quantity * PricePerPizza;
        }
        public double CalculateDiscountedPrice()
        {
            double totalPrice = CalculateTotalPrice();
            return totalPrice * (1 - discountPercent / 100);
        }

        public void ProcessOrder()
        {
            double discountedPrice = CalculateDiscountedPrice();
            totalRevenue += discountedPrice;
            totalPizzasSold += Quantity;

            Console.WriteLine($"Пицца: {PizzaName}, Количество: {Quantity}, Цена за шт.: {PricePerPizza} руб.");
            Console.WriteLine($"Полная стоимость: {CalculateTotalPrice()} руб.");
            Console.WriteLine($"Стоимость со скидкой: {discountedPrice} руб.");
            Console.WriteLine("Заказ обработан!");
        }
        public void PrintOrderInfo()
        {
            Console.WriteLine($"Пицца: {PizzaName}, Количество: {Quantity}, Цена за шт.: {PricePerPizza} руб.");
            Console.WriteLine($"Полная стоимость: {CalculateTotalPrice()} руб.");
            Console.WriteLine($"Стоимость со скидкой: {CalculateDiscountedPrice()} руб.");
        }

        public static void SetDiscount(double percent)
        {
            if (percent > 30)
            {
                discountPercent = 30;
                Console.WriteLine($"Скидка не может превышать 30%. Установлена скидка 30%.");
            }
            else if (percent < 0)
            {
                discountPercent = 0;
                Console.WriteLine($"Скидка не может быть отрицательной. Установлена скидка 0%.");
            }
            else
            {
                discountPercent = percent;
            }
        }

        public static void SetShopName(string name)
        {
            shopName = name;
        }

        public static void PrintStatistics()
        {
            Console.WriteLine($"Общая выручка: {totalRevenue} руб.");
            Console.WriteLine($"Всего продано пицц: {totalPizzasSold}");
        }
    }
}
