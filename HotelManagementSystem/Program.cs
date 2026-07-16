
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room("1", "Single", 20));
            rooms.Add(new Room("2", "Double", 30));
            rooms.Add(new Room("3", "Single", 20));
            rooms.Add(new Room("4", "Suite", 50));
            rooms.Add(new Room("5", "Double", 30));
            rooms.Add(new Room("6", "Double", 30));

            //Case 01 Add New Room
            void AddNewRoom()
            {

                try 
                {
                    // ask user to enter room number, room type (Single / Double / Suite), and price per night.
                    Console.Write("Enter room number: ");
                    string roomNum = Console.ReadLine();
                    if (int.Parse(roomNum) <= 0)
                    {
                        Console.WriteLine("Room number must be positive.");
                        return;
                    }

                    Console.Write("Enter room type (Single / Double / Suite): ");
                    string roomType = Console.ReadLine();

                    if (roomType.ToLower() != "single" && roomType.ToLower() != "double" && roomType.ToLower() != "suite")
                    {
                        Console.WriteLine("Room type must be (Single / Double / Suite)");
                        return;
                    }
                    Console.Write("Enter price per night: ");
                    double pricePerNight = double.Parse(Console.ReadLine());
                    if (pricePerNight <= 0)
                    {
                        Console.WriteLine("Room price must be positive.");
                        return;
                    }

                    Console.WriteLine("");
                    if (rooms.Any(r => r.roomNumber == roomNum))
                    {
                        Console.WriteLine("This room number cannot be used as it is already exist.");
                    }
                    else
                    {
                        rooms.Add(new Room(roomNum, roomType, pricePerNight));
                        Console.WriteLine("The room was added successfully.");

                        int count = rooms.Count();
                        rooms.FirstOrDefault(r => r.roomNumber == roomNum).displayRoom();

                        Console.WriteLine("There are " + count + " rooms");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            //Case 02 Register New Guest
            void RegisterNewGuest()
            {

                try
                {
                    // ask user to enter room number, room type (Single / Double / Suite), and price per night.
                    Console.Write("Enter guest name: ");
                    string guestName = Console.ReadLine();

                    Console.Write("Enter check-in date (yyyy-MM-dd): ");
                    DateTime checkInDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter number of nights: ");
                    int numberOfNights = int.Parse(Console.ReadLine());
                    if (numberOfNights <= 0)
                    {
                        Console.WriteLine("Number of nights must be positive.");
                        return;
                    }

                    string guestID = "G" + (guests.Count() + 1).ToString("D3");

                    string roomNumber = "Not Assigned";

                    guests.Add(new Guest(guestID, guestName, roomNumber, checkInDate, numberOfNights));

                    Console.WriteLine("The guest was added successfully.");

                    Console.WriteLine();
                    guests.FirstOrDefault(g => g.guestId == guestID).displayGuest();

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. ");
                }


            }

            //Case 03 Book a Room for a Guest
            void BookRoomForGuest()
            {
                try
                {
                    Console.Write("Enter guest ID: ");
                    string id = Console.ReadLine();
                    Guest guest = guests.FirstOrDefault(g => g.guestId == id);
                    if (guest == null)
                    {
                        Console.WriteLine("There is no guest with that ID");
                        return;
                    }

                    Console.Write("Enter room number: ");
                    string roomNum = Console.ReadLine();

                    Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNum);
                    if (room == null)
                    {
                        Console.WriteLine("There is no room with that number");
                        return;
                    }

                    if (!(room.isAvailable))
                    {
                        Console.WriteLine("Room is already booked.");
                        return;
                    }

                    guest.roomNumber = room.roomNumber;

                    room.isAvailable = false;

                    Console.WriteLine("");

                    guest.displayGuest();

                    Console.WriteLine("Room type: " + room.roomType);
                    Console.WriteLine("Price per night: " + room.pricePerNight.ToString("F2"));
                    Console.WriteLine("Total cost: " + guest.calculateTotalCost(room).ToString("F2"));


                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. ");
                }


            }

            //Case 04 View All Rooms
            void ViewAllRooms()
            {
                int count = rooms.Count();
                if (count == 0)
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                var roomInfo = rooms.OrderBy(r => int.Parse(r.roomNumber))
                    .Select(r => $"Room number: {r.roomNumber} | Room type: {r.roomType} | Price per night: {r.pricePerNight} | Availability status {(r.isAvailable ? "Available" : "Booked")}")
                    .ToList();
                Console.WriteLine("This hotel has " + count + " rooms");
                foreach (string line in roomInfo)
                {
                    Console.WriteLine(line);
                }
                
            }

            //Case 05 View All Guests
            void ViewAllGuests()
            {
                int count = guests.Count();
                if (count == 0)
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                var guestsInfo = guests.OrderBy(g => g.guestName)
                    .Select(g => $"Guest ID: {g.guestId} | Guest name: {g.guestName} | Room number: {g.roomNumber} | Check-in date: {g.checkInDate.ToString("yyyy-MM-dd")} | Total nights: {g.totalNights}")
                    .ToList();
                Console.WriteLine("This hotel has " + count + " guests");
                foreach (string line in guestsInfo)
                {
                    Console.WriteLine(line);
                }

            }

            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("================================================");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 15 or 0 to exit.");
                    Console.WriteLine("Press any key to clear");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Goodbye!");
                        return;

                    case 1:
                        AddNewRoom();
                        break;

                    case 2:
                        RegisterNewGuest();
                            break;

                    case 3:
                        BookRoomForGuest();
                        break;

                    case 4:
                        ViewAllRooms();
                        break;

                    case 5:
                        ViewAllGuests();
                        break;

                    default:
                        Console.WriteLine("Invalid option, please choose between 1 to 15 or 0 to exit.");
                        break;
                }

                Console.WriteLine("Press any key to clear");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
