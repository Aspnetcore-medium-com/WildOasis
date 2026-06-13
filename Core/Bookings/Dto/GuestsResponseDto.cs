using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Bookings.Dto
{
    public class GuestsResponseDto
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Nationality { get; set; } = string.Empty;

        public string CountryFlag {  get; set; } = string.Empty;

        public string NationalId { get; set; } = string.Empty;
    }
}
