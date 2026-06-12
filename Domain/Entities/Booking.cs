

namespace Domain.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int NumOfNights { get; set; }

        public int NumOfGuests { get; set; }

        public decimal CabinPrice { get; set; }

        public decimal ExtrasPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; } = string.Empty;

        public bool HasBreakFast { get; set; }

        public bool IsPaid { get; set; }

        public string Observations { get; set; } = string.Empty;

        // FK Fields
        public Guid CabinId { get; set; }

        public Guid GuestId { get; set; }


        // Navigation properties
        public Cabin Cabin { get; set; }

        public Guest Guest { get; set; }
    }
       
}
