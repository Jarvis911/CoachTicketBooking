namespace CoachTicketBooking.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Departure { get; set; } = string.Empty; // Điểm khởi hành
        public string Destination { get; set; } = string.Empty; // Điểm đến
        public DateTime DepartureTime { get; set; } // Thời gian khởi hành
        public DateTime ArrivalTime { get; set; } // Thời gian đến
        public decimal Price { get; set; } // Giá vé
        public int BusId { get; set; }
        public Bus? Bus { get; set; }
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
}
