using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<Hotel> Hotels = new List<Hotel>();
            Hotel hotel1 = new Hotel("Unirea", "Iasi");
            Hotel hotel2 = new Hotel("Hilton", "London");
            Hotel hotel3 = new Hotel("Belvedere", "Italia");

            //Adding hotels to the list
            Hotels.Add(hotel1);
            Hotels.Add(hotel2);
            Hotels.Add(hotel3);

            // --- POPULATING HOTELS WITH ROOMS ---
            hotel1.AddCompleteRoom("C10", 1, 1, 0,270,"lei"); // (name,stars,adults,children,amount,currency) /day
            hotel1.AddCompleteRoom("C11", 2, 2, 0,280,"lei");
            hotel1.AddCompleteRoom("C12", 3, 2, 1,300,"lei");
            hotel1.AddCompleteRoom("C13", 4, 2, 2,350,"lei");
            hotel1.AddCompleteRoom("C14", 5, 2, 2,380,"lei");
            //-------------------------------------
            hotel2.AddCompleteRoom("B10", 1, 1, 0,300,"pounds");
            hotel2.AddCompleteRoom("B11", 2, 1, 0,320,"pounds");
            // Am omis o camera de 3 stele pentru test;
            hotel2.AddCompleteRoom("B12", 4, 2, 2,430,"pounds");
            hotel2.AddCompleteRoom("B13", 5, 2, 1,550,"pounds");
            //-------------------------------------
            hotel3.AddCompleteRoom("A10", 1, 1, 0,150,"euro");
            hotel3.AddCompleteRoom("A11", 2, 1, 1,200,"euro");
            hotel3.AddCompleteRoom("A12", 3, 2, 0, 220,"euro");
            hotel3.AddCompleteRoom("A13", 4, 2, 1,250,"euro");
            hotel3.AddCompleteRoom("A14", 5, 2, 0, 270,"euro");

            //Removing hotels from the list
            //Hotels.Remove(hotel1);
            //Hotels.Remove(hotel3);
            

            foreach(Hotel hotel in Hotels) // afisez detaliile pentru fiecare hotel
                hotel.Print();

            //testing GetPriceForNumberOfRooms(int numberOfRooms)
            Console.WriteLine("Pretul pentru doua camere in Hotel Unirea este: ");
            int test1 = hotel1.GetPriceForNumberOfRooms(2); // pentru 3 stele ar trebui sa afiseze 600 lei
            Console.Write(test1);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Pretul pentru doua camere in Hotel Hilton este: ");
            int test2 = hotel2.GetPriceForNumberOfRooms(2); // pentru 3 stele ar trebui sa afiseze un mesaj
            Console.Write(test2);
            Console.WriteLine();
            Console.WriteLine("------------");

            //testing string GetPriceForDays(int numberOfDays)
            Console.WriteLine("Checking price for days in room A10");
            string test3 = hotel3.Rooms[0].GetPriceForDays(3); // output should be: 450 euro for 3 days
            Console.WriteLine(test3);
            Console.WriteLine();

            //testing GetRoom(List<Hotel> Hotels,int Price,string Currency)
            Console.WriteLine("Searching room for <= 300 lei");
            foreach (Hotel hotel in Hotels)
                hotel.GetRoom(300, "lei");

            Console.WriteLine();
        
            Console.WriteLine("Searching room for <= 200 pounds");
            foreach(Hotel hotel in Hotels)
                hotel.GetRoom(200, "pounds");

            




            Console.ReadKey();
        }
        

        
    }
}
