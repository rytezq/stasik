using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stasik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Audi","Q8", 450);
            Car car3 = new Car("BMW", "X3", 300);

            car1.Printinfo();
            car2.Printinfo();
            car3.Printinfo();
            Console.WriteLine($"Общее количество машин: {Car.GetTotalCars()}");
        }
    }
    class Car
    {
        public string Brand;
        public string Model;
        public int Speed;
        private static int totalCarsCreated = 0;

        public Car()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Speed = 0;
            totalCarsCreated++;
        }
        public Car(string brand, string model, int speed)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            totalCarsCreated++;
        }
        public static int GetTotalCars()
        {
            return totalCarsCreated;
        }
        public void Printinfo()
        {
            Console.WriteLine($"Бренд авто: {Brand}. Модель: {Model}. Скорость: {Speed}.");
        }
    }
}
