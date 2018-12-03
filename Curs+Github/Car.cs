using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Github
{
    
    class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }
        /// <summary>
        /// Searching all cars with price more than 10 000$
        /// </summary>
        /// <param name=List<Car></param>
        /// <returns>Returns List<cars> </cars></returns>
        public List<Car> Price_more_10000(List<Car> cars)
        {
            var c = cars.Where(p => (p.Price > 10000));
            List<Car> tmp = c.ToList();
            return tmp;
        }
        public List<Car> Choose_by_colour(List<Car> cars)
        {
            var c = cars.Where(p => (p.Colour.ToLower()=="red"));
            List<Car> tmp = c.ToList();
            
            return tmp;
        }
        public List<Car> Choose_by_price_mark(List<Car> cars)
        {
            var c = cars.Where(p => (p.Mark.ToLower() == "toyota" & p.Price>10000));
            List<Car> tmp = c.ToList();
            return tmp;
        }
        public decimal Summ_All(List<Car> cars)
        {
            var tmp = cars.Sum(p=>p.Price);
            return tmp;
        }
        public int Count_by_colour(List<Car> cars)
        {
            var count=cars.Count(p=>p.Colour.ToLower()=="red");
            return count;
        }
        public dynamic Chip_Cars(List<Car> cars)
        {
            var tmp = cars.Where(p => p.Price < 5_000).Select(p => new { Mark = p.Mark, Model = p.Model });
            return tmp;

        }
        public (int black,int white) BlackWhite(List<Car> cars,decimal st, decimal fin)
        {
            var black = cars.Where(p => p.Price > st & p.Price < fin).Count(p => p.Colour.ToLower() == "black");
            var white = cars.Where(p => p.Price > st & p.Price < fin).Count(p => p.Colour.ToLower() == "white");
            return (black,white);
        }
        public override string ToString()
        {
            return $"Mark: {Mark} Model: {Model} Price: {Price} Colour: {Colour}";
        }
    }
    
}
