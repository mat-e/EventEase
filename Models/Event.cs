using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        //public Event()
        //{
        //}

        [Key]
        [Required]
        public int EventId { get; set; }

        [Required]
        public string? EventName { get; set; }

        [Required]
        public DateOnly EventDate { get; set; }

        [Required]
        public required string EventDescription { get; set; }

        //public ICollection<Booking>? Bookings { get; set; }

        //// Explicit FK property (nullable if an Event may not have a Venue)
         
    }
}
