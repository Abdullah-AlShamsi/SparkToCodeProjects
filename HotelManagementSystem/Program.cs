namespace HotelManagementSystem
{
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
