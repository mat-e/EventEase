using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        public Event()
        {
                
        }
        [Key]
        public int EventId { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateOnly EventDate { get; set; }
        [Required]
        public required string EventDescription { get; set; }

        [ForeignKey("VenueId")]
        public  Venue Venue { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
