using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }

        public Car(string name, int price, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Car Brand: {Name}, Price: {Price}, Color: {Color}";
        }
    }
}
