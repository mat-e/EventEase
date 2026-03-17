using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        //public Booking()
        //{

        //}
        [Key]
        [Required]
        public int BookingId { get; set; }
        [Required]

        //nav for venue

        //[ForeignKey("VanueId")]
        public string? VanueId { get; set; }
        public Venue? Venue { get; set; }

        public string? EventId { get; set; }
        public Event? Event { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
