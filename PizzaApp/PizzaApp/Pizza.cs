using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Pizza
    {

        public Pizza(string PizzaName,PizzaBase blat) {
            this.Name = PizzaName;
            this.pizzaBase = blat;
            sum += blat.Cost;
        }
        public double sum = 0;
        
        public string Name { get; set; }
        PizzaBase pizzaBase;
        
        List<PizzaTopping> Topping = new List<PizzaTopping>();

        public void AddTopping(string ToppingName, double Cost)
        {
            PizzaTopping topp = new PizzaTopping();
            topp.Topping = ToppingName;
            topp.Cost = Cost;
            Topping.Add(topp);
        }

        

        public void Print()
        {
            Console.WriteLine("Pizza " + Name);
            Console.WriteLine($"Base {pizzaBase.Name}: (${pizzaBase.Cost})");
            Console.WriteLine("Toppings: ");
            foreach(PizzaTopping topp in Topping)
            {
                sum += topp.Cost;
                Console.WriteLine($"--{topp.Topping} (${topp.Cost})"); 
                }
            Console.WriteLine($"Total cost: $({sum})");

            Console.WriteLine("------------");
            
        }
    }
}