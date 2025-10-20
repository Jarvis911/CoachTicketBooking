using System.ComponentModel.DataAnnotations;

namespace CoachTicketBooking.Models
{
    public class Bus
    {
        [Key]
        public int Id { get; set; }
        public string? LicensePlate { get; set; }
        public int TotalSeats { get; set; }
        public int OwnerId { get; set; } // Thêm Owner
        public User Owner { get; set; } = null!;
        public ICollection<Trip> Trips { get; set; }
    }
}
