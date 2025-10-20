using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoachTicketBooking.Models
{
    public class User : IdentityUser<int>
    {
        public string Role { get; set; } // "Customer" or "Owner"
        public ICollection<Bus> Buses { get; set; } // For Owners only
        public ICollection<Booking> Bookings { get; set; } // For Customers
    }
}
