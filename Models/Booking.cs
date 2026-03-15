using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        public Booking()
        {
                
        }
        [Key]
        public int BookingId { get; set; }
        [Required]
        public DateOnly BookingDate { get; set; }

        //nav for vaue
        public int VenueId { get; set; }
        public Venue Venue { get; set; }


        //nav for Event
        public int EventId { get; set; }
        public Event Event { get; set; }
    } 
}
