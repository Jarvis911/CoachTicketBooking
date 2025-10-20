using Microsoft.AspNetCore.SignalR;

namespace CoachTicketBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public User? Customer { get; set; }
        public int SeatId { get; set; }
        public Seat? Seat { get; set; }
        public DateTime BookingTime { get; set; } = DateTime.UtcNow;
    }
}
