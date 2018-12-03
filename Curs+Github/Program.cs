
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Github
{
    class Program
    {
        public static void Show(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
           
            List<Car> cars = new List<Car>
            {
                new Car{Mark="Lexus", Model="LX_470",Price=42_000, Colour="Black"},
                new Car{Mark="Toyota", Model="Camry",Price=22_000, Colour="White"},
                new Car{Mark="Renault", Model="Logan",Price=9_000, Colour="Black"},
                new Car{Mark="Opel", Model="Vectra",Price=8_000, Colour="Red"},
                new Car{Mark="Daewoo", Model="Lanos",Price=6_000, Colour="Red"},
                new Car{Mark="Toyota", Model="Corolla",Price=9_000, Colour="Black"},
                new Car{Mark="Toyota", Model="Land Cruiser",Price=12_000, Colour="White"},
                new Car{Mark="Toyota", Model="Auris",Price=8_000, Colour="Red"},
                new Car{Mark="Lada", Model="Niva",Price=4_000, Colour="Red"},
                new Car{Mark="Zaz", Model="Forza",Price=3_500, Colour="Red"},
            };
            Car a = new Car();
            Console.WriteLine("Выбор по цене");
            List<Car> price = a.Price_more_10000(cars);
            Show(price);
            Console.WriteLine("Выбор по цвету");
            List<Car> col = a.Choose_by_colour(cars);
            Show(col);
            Console.WriteLine("Выор по марке и цене");
            List<Car> mp = a.Choose_by_price_mark(cars);
            Show(mp);
            
            decimal s = a.Summ_All(cars);
            Console.WriteLine($"Общая стоимость всех машин: {s} $");

            int count = a.Count_by_colour(cars);
            Console.WriteLine($"Машин красного цвета: {count}");

            dynamic tmp = a.Chip_Cars(cars);
            foreach (var item in tmp)
            {
                Console.WriteLine($"Mark: {item.Mark} Model: {item.Model}");
            }
            Console.WriteLine("Укажите диапазон цен для поиска");
            decimal st, fin;
            st = decimal.Parse(Console.ReadLine());
            fin = decimal.Parse(Console.ReadLine());
            var bw = a.BlackWhite(cars, st, fin);
            Console.WriteLine($"Черных машин: {bw.black}шт. белых машин: {bw.white}шт.");
        }
    }

}
