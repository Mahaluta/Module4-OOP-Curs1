using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Hotel
    {
        
        public Hotel(string Name,string City)
        {
            this.Name = Name;
            this.City = City;
        }

        private string Name { get; }
        private string City { get; }
        public List<Room> Rooms = new List<Room>();

        public void AddCompleteRoom(string Name, int Stars, int Adults, int Children,int Amount,string Currency)
        {
            Room room = new Room();
            room.Name = Name;
            room.Stars = Stars;
            room.Adults = Adults;
            room.Children = Children;
            room.rate.Amount = Amount;
            room.rate.Currency = Currency;
            Rooms.Add(room);        
        }

        public int GetPriceForNumberOfRooms(int numberOfRooms)
        {
            Console.Write("How many stars should the room have?");
            int strs = Convert.ToInt32(Console.ReadLine());           
            foreach(Room room in Rooms)
                    {
                if (room.Stars == strs)
                {
                    Console.Write("The price for " + numberOfRooms + " is: ");
                    return room.rate.Amount * numberOfRooms;
                }


                    }
            Console.WriteLine("In this hotel we couldn't find a room with " + strs + " stars.");
            Console.WriteLine();
            return -1;
            }

        public void GetRoom(int Price, string Currency)
        {
            bool ok = false;
            foreach (Room room in Rooms)
            {
                if (room.rate.Currency == Currency)
                    if (room.rate.Amount <= Price)
                    {
                        room.Print();
                        ok = true;
                    }
            }
            if (ok == false)
            {
                Console.Write("We couldn't find any rooms with this specification in the hotel: ");
                PrintName();
                Console.WriteLine();
            }
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(City);
            foreach (Room room in Rooms)
                room.Print();

        }

        public void PrintName()
        {
            Console.Write(Name);
        }

        ~Hotel()
        {
            Console.WriteLine("The destructor is called");
        }
    }
}
