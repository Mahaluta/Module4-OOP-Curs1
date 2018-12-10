using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaTopping
    {
        public string Topping { get; set; }
        public double Cost { get; set; }
        public void Print()
        {
            Console.WriteLine("The topping is: " + Topping);
            Console.WriteLine("The cost is: " + Cost);
        }
    }
}
