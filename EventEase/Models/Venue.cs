using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }

        [Display(Name = "Venue Location")]
        public string VenueLocation { get; set; }

        public int Capacity { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public List<Booking> Bookings { get; set; } = new();
    }
}
