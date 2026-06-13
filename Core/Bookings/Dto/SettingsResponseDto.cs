using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Bookings.Dto
{
    public class SettingsResponseDto
    {
        public Guid Id { get; set; }

        public int MinBookingLength { get; set; }

        public int MaxBookingLength { get; set; }

        public int MaxNumberOfGuestsPerBooking { get; set; }

        public decimal BreakfastPrice { get; set; }
    }
}
