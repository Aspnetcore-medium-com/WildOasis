using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Bookings.Dto
{
    public class CabinResponseDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public int MaxCapacity { get; set; }

        public decimal RegularPrice { get; set; }

        public int Discount { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Image {  get; set; } = string.Empty ;
    }
}
