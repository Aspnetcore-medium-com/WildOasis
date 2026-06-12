

namespace Domain.Entities
{
    public class Setting
    {
        public Guid Id {  get; set; }

        public int MinBookingLength { get; set; }

        public int MaxBookingLength { get; set; }

        public int MaxNumberOfGuestsPerBooking { get; set; }

        public decimal BreakfastPrice { get; set; }
    }
}
