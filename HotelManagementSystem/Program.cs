namespace HotelManagementSystem
{
    


    class Guest
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
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(1, "Single", 20, true));
            rooms.Add(new Room(2, "Double", 30, true));
            rooms.Add(new Room(3, "Single", 20, true));
            rooms.Add(new Room(4, "Suite", 50, true));
            rooms.Add(new Room(5, "Double", 30, true));
            rooms.Add(new Room(6, "Double", 30, true));
        }
    }
}
