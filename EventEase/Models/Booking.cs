using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]

        public int Id { get; set; }

        public int VenueId { get; set; }

        public Venue? Venue { get; set; }
        
        public int EventId { get; set; }

        public Event? Event { get; set; }

        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
    }
}
