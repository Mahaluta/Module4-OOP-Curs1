using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaBase
    {
        public PizzaBase(string BaseName)
        {
            this.Name = BaseName;
            if (BaseName == "Italian")
                Cost = 1.5 * BaseCost;
            else if (BaseName == "Crusty")
                Cost = 1.8 * BaseCost;
            else {
                Name = "Regular";
                Cost = BaseCost;
            }
        }

        public int BaseCost = 5;
        public string Name { get; set; }
        public double Cost { get; set; }
        public void Print()
        {
            Console.WriteLine("The pizza has " + Name + " base");
            Console.WriteLine("The pizza costs " + Cost);
        }
    }
}
