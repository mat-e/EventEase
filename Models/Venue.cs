using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace EventEase.Models
{
    public class Venue
    {
        //public Venue()
        //{
            
        //}
        [Key]
        [Required]
        public int VenueId { get; set; }
        [Required]
        [StringLength(50)]
        public string? VenueName { get; set; }
        [Required]
        public string? Location { get;   set; }
       
        public int? Capacity { get; set; }
       
        public string? ImageUrl { get; set; }


        ////Navigations
        //public Booking? Booking { get; set; }
        //public Event? Event { get; set; }    
        //public ICollection<Event>? Events { get; set; }
        //public ICollection<Booking>? Bookings { get; set; }

    }
}
