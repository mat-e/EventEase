using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace EventEase.Models
{
    public class Venue
    {
        public Venue()
        {
            
        }
        [Key]
        public int VenueId { get; set; }
        [Required]
        public string VenueName { get; set; }
        [Required]
        public string Location { get;   set; }
        [Required]
        public int Capacity { get; set; }
        
        public Venue(int capacity)
        {
            Capacity = capacity;
        }

        [Required]
        public string ImageUrl { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
