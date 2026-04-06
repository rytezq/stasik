using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите курс доллара");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите курс евро");
            double euro = Convert.ToDouble(Console.ReadLine());
            CorrencyConverter.SetRates(usd, euro);
            Console.WriteLine($"Сколько долларов вы хотите обменять");
            double usdConvert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы получите {CorrencyConverter.ConvertUsdToRub(usdConvert)} руб");
            Console.WriteLine($"Сколько евро вы хотите обменять");
            double euroConvert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы получите {CorrencyConverter.ConvertEuroToRub(euroConvert)} руб");
        }
    }
    class CorrencyConverter
    {
        private static double UsdToRubRate;
        private static double EuroToRubRate;
        public static void SetRates(double usdRate, double euroRate)
        {
            UsdToRubRate = usdRate;
            EuroToRubRate = euroRate;
            Console.WriteLine($"Курсы валют установленны");
        }
        public static double ConvertUsdToRub(double usd)
        {
            return usd * UsdToRubRate;
        }
        public static double ConvertEuroToRub(double euro)
        {
            return euro * EuroToRubRate;
        }
    }
}
