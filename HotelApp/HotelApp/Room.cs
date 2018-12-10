using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelApp
{
    class Room
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Rate rate = new Rate();

        public void AddRate(int Amount, string Currency)
        {
            this.rate.Amount = Amount;
            this.rate.Currency = Currency;
        }


        public string GetPriceForDays(int numberOfDays)
        {
            return $"The room costs: {rate.Amount*numberOfDays} {rate.Currency} for {numberOfDays} days. ";
        }

        public void Print()
        {
            Console.WriteLine("The room's name is: " + Name);
            Console.WriteLine("The room has " + Stars + " stars.");
            Console.WriteLine("In this room can be " + Adults + " adults.");
            Console.WriteLine("In this room can be " + Children + " kids.");
            Console.WriteLine("The room's price and currency for a day: " + rate.Amount + " " + rate.Currency);
            Console.WriteLine();
        }
    }
}
