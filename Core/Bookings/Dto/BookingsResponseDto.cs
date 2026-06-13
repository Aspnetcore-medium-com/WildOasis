using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Bookings.Dto
{
    public class BookingsResponseDto
    {
        public int BookingId {get; set;}

        public DateTime CreatedAt { get; set;}

        public DateOnly StartDate { get; set;}

        public DateOnly EndDate { get; set;}

        public int NumOfNights { get; set;}

        public int NumOfGuests { get; set;}

        public decimal CabinPrice { get; set;}

        public decimal ExtrasPrice { get; set;}

        public decimal TotalPrice { get; set;}

        public string Status { get; set;} = string.Empty;

        public bool HasBreakFast { get; set;}

        public bool IsPaid { get; set;}
        public string Observations { get; set; } = string.Empty;

        public CabinResponseDto Cabin { get; set; }

        public GuestsResponseDto Guest { get; set; }
    }
}
