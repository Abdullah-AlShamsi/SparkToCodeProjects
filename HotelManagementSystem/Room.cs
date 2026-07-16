using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Room
    {
        public string roomNumber { get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }


        public Room(string number, string type, double price)
        {
            roomNumber = number;
            roomType = type;
            pricePerNight = price;
            isAvailable = true;

        }

        public void displayRoom()
        {
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Price Per Night: " + pricePerNight);
            if (isAvailable)
            {
                Console.WriteLine("Is Available: Available");
            }
            else
            {
                Console.WriteLine("Is Available: Not Available");
            }

        }
    }
}
