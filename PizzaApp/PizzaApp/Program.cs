using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalizing the objects;
            PizzaBase blat1 = new PizzaBase("Italian");
            Pizza pizza1 = new Pizza("Diablo",blat1);

            PizzaBase blat2 = new PizzaBase("Crusty");
            Pizza pizza2 = new Pizza("Traditionl",blat2);

            PizzaBase blat3 = new PizzaBase("Regular");
            Pizza pizza3 = new Pizza("Seoul",blat3);

            // Populating with toppings
            pizza1.AddTopping("Mozzarella", 6.3);
            pizza1.AddTopping("Chicken", 7.1);
            pizza1.AddTopping("Tomato sauce", 2.1);
            pizza1.AddTopping("Pepperoni", 5.3);
            //------------------
            pizza2.AddTopping("Mozzaerlla", 6.3);
            pizza2.AddTopping("Pepperoni", 5.3);
            pizza2.AddTopping("Sausage", 3.3);
            //------------------
            pizza3.AddTopping("Tomato sauce", 2.1);
            pizza3.AddTopping("Mozarella", 6.3);
            pizza3.AddTopping("Tomatoes", 1.8);
            pizza3.AddTopping("Olives", 2.2);
            //------------------

            List<Pizza> Order = new List<Pizza>();
            Order.Add(pizza1);
            Order.Add(pizza2);
            Order.Add(pizza3);

            foreach (Pizza pizza in Order)
                pizza.Print();

            Console.ReadKey();


            
        }
    }
}
