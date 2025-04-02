using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Event Name")]
        
        public string EventName { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        public List<Booking> Bookings { get; set; } = new();

    }
}
