using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Guest
    {
        public int guestId { get; }
        public string guestName { get; set; }
        public int roomNumber { get; set; }
        public DateTime checkInDate { get; set; }

        public int totalNights { get; set; }


        public Guest(int id, string name, int roomNum, DateTime dayCheckIN, int total)
        {
            guestId = id;
            guestName = name;
            roomNumber = roomNum;
            checkInDate = dayCheckIN;
            totalNights = total;

        }

        public void displayGuest()
        {
            Console.WriteLine("Guest Id: " + guestId);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Check In Date: " + checkInDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Total Nights: " + totalNights);


        }

        public double calculateTotalCost(Room room)
        {
            return room.pricePerNight * totalNights;
        }
    }
}
