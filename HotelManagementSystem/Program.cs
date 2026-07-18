
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
                    .Select(r => $"Room number: {r.roomNumber} | Room type: {r.roomType} | Price per night: {r.pricePerNight} | Availability status: {(r.isAvailable ? "Available" : "Booked")}")
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

            // Case 06 Search & Filter Rooms
            void AvailableRooms()
            {
                var availableRooms = rooms.OrderBy(r => r.pricePerNight)
                                .Where(r => r.isAvailable)
                                .Select(r => $"Room number: {r.roomNumber} | Room type: {r.roomType} | Price per night: {r.pricePerNight.ToString("F2")}")
                                .ToList();

                if (availableRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms found for the selected criteria.");
                    return;
                }
                Console.WriteLine("================================================================================================");
                Console.WriteLine("This hotel has " + availableRooms.Count + " available rooms");
                Console.WriteLine("================================================================================================");
                foreach (string line in availableRooms)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("================================================================================================");
            }

            void RoomsByType()
            {
                Console.Write("Enter room type (Single / Double / Suite): ");
                string type = Console.ReadLine();

                if (type.ToLower() != "single" && type.ToLower() != "double" && type.ToLower() != "suite")
                {
                    Console.WriteLine("Room type must be (Single / Double / Suite)");
                    return;
                }
                var roomsInfo = rooms.OrderBy(r => r.pricePerNight)
                    .Where(r => r.roomType == type.ToLower())
                    .Select(r => $"Room number: {r.roomNumber} | Room type: {r.roomType} | Price per night: {r.pricePerNight.ToString("F2")}| Availability status: {(r.isAvailable ? "Available" : "Booked")}")
                    .ToList();

                if (roomsInfo.Count() == 0)
                {
                    Console.WriteLine("No rooms found for the selected criteria.");
                    return;
                }
                Console.WriteLine("================================================================================================");
                Console.WriteLine("This hotel has " + roomsInfo.Count() + " " + type + " rooms");
                Console.WriteLine("================================================================================================");
                foreach (string line in roomsInfo)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("================================================================================================");
            }

            void RoomsByMaxPrice()
            {
                try
                {
                    Console.Write("Enter max Price: ");
                    double maxPrice = double.Parse(Console.ReadLine());

                    if (maxPrice <= 0)
                    {
                        Console.WriteLine("Max price must be positive.");
                        return;
                    }
                    var roomsInfo = rooms.OrderBy(r => r.pricePerNight)
                        .Where(r => r.pricePerNight <= maxPrice && r.isAvailable)
                        .Select(r => $"Room number: {r.roomNumber} | Room type: {r.roomType} | Price per night: {r.pricePerNight.ToString("F2")}")
                        .ToList();
                    if (roomsInfo.Count() == 0)
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }

                    Console.WriteLine("================================================================================================");
                    Console.WriteLine("This hotel has " + roomsInfo.Count + " rooms at or below " + maxPrice.ToString("F2"));
                    Console.WriteLine("================================================================================================");
                    foreach (string line in roomsInfo)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("================================================================================================");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. ");
                }
            }

            void RoomPriceStatistics()
            {
                int totalRooms = rooms.Count();
                int availableRooms = rooms.Count(r => r.isAvailable);
                double avePrice = rooms.Average(r => r.pricePerNight);
                double minPrice = rooms.Min(r => r.pricePerNight);
                double maxPrice = rooms.Max(r => r.pricePerNight);
                Console.WriteLine("================================================================================================");
                Console.WriteLine("This hotel has " + totalRooms + " rooms");
                Console.WriteLine("This hotel has " + availableRooms + " available rooms");
                Console.WriteLine("Average price per night: " + avePrice.ToString("F2"));
                Console.WriteLine("Cheapest price per night: " + minPrice.ToString("F2"));
                Console.WriteLine("Most expensive price per night: " + maxPrice.ToString("F2"));
                Console.WriteLine("================================================================================================");
            }
            void SearchFilterRooms()
            {
                while (true)
                {
                    Console.WriteLine("================================================");
                    Console.WriteLine("Search & Filter Rooms");
                    Console.WriteLine("================================================");
                    Console.WriteLine(" 1. Show all available rooms");
                    Console.WriteLine(" 2. Filter by room type");
                    Console.WriteLine(" 3. Filter by max price");
                    Console.WriteLine(" 4. Room price statistics");
                    Console.WriteLine(" 0. Back");
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
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 15 or 0 to Back.");
                        Console.WriteLine("Press any key to clear");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    switch (choice)
                    {
                        case 0:
                            return;

                        case 1:
                            AvailableRooms();
                            break;

                        case 2:
                            RoomsByType();
                            break;


                        case 3:
                            RoomsByMaxPrice();
                            break;

                        case 4:
                            RoomPriceStatistics();
                            break;

                        default:
                            Console.WriteLine("Invalid option, please choose between 1 to 4 or 0 to back.");
                            break;
                    }
                    Console.WriteLine("Press any key to clear");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            // Case 07 Guest & Booking Statistics 
            void GuestBookingStatistics()
            {
                int totalGuests = guests.Count();
                int guestsAssignedRoom = guests.Count(g => g.roomNumber != "Not Assigned");
                int totalRooms = rooms.Count();
                int bookedRooms = rooms.Count(r => !r.isAvailable);
              
                Console.WriteLine("================================================================================================");
                Console.WriteLine("This hotel has " + totalGuests + " guests");
                Console.WriteLine("This hotel has " + totalRooms + " rooms");
                if (guestsAssignedRoom == 0)
                {
                    Console.WriteLine("No active bookings recorded");
                    return;
                }
                Console.WriteLine("This hotel has " + guestsAssignedRoom + " guests have a room assigned");
                
                Console.WriteLine("This hotel has " + bookedRooms + " rooms currently booked");
                double aveNights = guests.Where(g => g.roomNumber != "Not Assigned")
                    .Average(g => g.totalNights);
                Console.WriteLine("The average number of nights across all guests who have an active booking: " + aveNights.ToString("F2"));
                Console.WriteLine("================================================================================================");


                var highestSpendingGuests = guests.Where(g => g.roomNumber != "Not Assigned")
                    .OrderByDescending(g => g.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber)))
                    .Take(3)
                    .Select(g => $"Guest name: {g.guestName} | Room number: {g.roomNumber} | Total cost: {g.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber)).ToString("F2")}")
                    .ToList();
                foreach (string line in highestSpendingGuests)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("================================================================================================");
                
                var bookedGuests = guests.Where(g => g.roomNumber != "Not Assigned")
                    .Select(g => $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {g.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber)).ToString("F2")}")
                    .ToList();
                foreach (string line in bookedGuests)
                {
                    Console.WriteLine(line);
                }
            }


            //Case 08 Update Room Price 

            void UpdateRoomPrice()
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
                    Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNum);
                    if (room == null)
                    {
                        Console.WriteLine("There is no room with that number");
                    }
                    else
                    {
                        Console.Write("Enter new price per night: ");
                        double newPricePerNight = double.Parse(Console.ReadLine());
                        if (newPricePerNight <= 0)
                        {
                            Console.WriteLine("Room price must be positive.");
                            return;
                        }
                        double oldPrice = room.pricePerNight;
                        room.pricePerNight = newPricePerNight;
                        Console.WriteLine("The price was updated successfully.");
                        Console.WriteLine("The old price: " + oldPrice.ToString("F2"));
                        Console.WriteLine("The new price: " + newPricePerNight.ToString("F2"));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            //Case 09 Guest Lookup by Name
            void GuestLookupByName()
            {

                Console.WriteLine("Enter a name or partial name: ");
                string name = Console.ReadLine();

                var Guests = guests.Where(g => g.guestName.ToLower().Contains(name.ToLower()))
                    .Select(g => $"Guest ID: {g.guestId} | Guest name: {g.guestName} | Room number: {g.roomNumber}")
                    .ToList();
                int count = Guests.Count();
                if(count == 0)
                {
                    Console.WriteLine("No guests matched that search.");
                    return;
                }

                Console.WriteLine("There are " +count +" guests matched that search.");
                foreach (string line in Guests)
                {
                    Console.WriteLine(line);
                }
            }


            //Case 10 Room Type Breakdown Report
            void RoomTypeBreakdownReport()
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Single Rooms Report: ");
                int singleCount = rooms.Count(r => r.roomType == "single");
                if (singleCount == 0)
                {
                    Console.WriteLine("N/A");
                }
                else
                {
                    Console.WriteLine("Total rooms: " + singleCount);
                    Console.WriteLine("Avarage price per night: " + rooms.Where(r => r.roomType == "single").Average(r => r.pricePerNight).ToString("F2"));
                }


                Console.WriteLine("================================================");
                Console.WriteLine("Double Rooms Report: ");
                int doubleCount = rooms.Count(r => r.roomType == "double");
                if (doubleCount == 0)
                {
                    Console.WriteLine("N/A");
                }
                else
                {
                    Console.WriteLine("Total rooms: " + doubleCount);
                    Console.WriteLine("Avarage price per night: " + rooms.Where(r => r.roomType == "double").Average(r => r.pricePerNight).ToString("F2"));
                }

                Console.WriteLine("================================================");
                Console.WriteLine("Suite Rooms Report: ");
                int suiteCount = rooms.Count(r => r.roomType == "suite");
                if (suiteCount == 0)
                {
                    Console.WriteLine("N/A");
                }
                else
                {
                    Console.WriteLine("Total rooms: " + suiteCount);
                    Console.WriteLine("Avarage price per night: " + rooms.Where(r => r.roomType == "suite").Average(r => r.pricePerNight).ToString("F2"));
                }

                Console.WriteLine("================================================");
                Console.WriteLine("Overall Report: ");
                int allCount = rooms.Count();
                if (allCount == 0)
                {
                    Console.WriteLine("N/A");
                }
                else
                {
                    Console.WriteLine("Total rooms: " + allCount);
                    Console.WriteLine("The overall average price across all rooms: " + rooms.Average(r => r.pricePerNight).ToString("F2"));
                }
                Console.WriteLine("================================================");
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

                    case 6:
                        SearchFilterRooms();
                        break;

                    case 7:
                        GuestBookingStatistics();
                        break;

                    case 8:
                        UpdateRoomPrice();
                        break;

                    case 9:
                        GuestLookupByName();
                        break;

                    case 10:
                        RoomTypeBreakdownReport();
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
