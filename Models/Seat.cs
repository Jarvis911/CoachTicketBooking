namespace CoachTicketBooking.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; } // Số ghế
        public bool IsAvailable { get; set; } = true; // Có sẵn không
        public int TripId { get; set; }
        public Trip? Trip { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
