using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Cabin
    {
        public Guid Id { get; set; } 

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public int MaxCapacity { get; set; }

        public decimal RegularPrice { get; set; }

        public int Discount { get; set; }

        [MaxLength(300)]
        public string Description { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

    }
}
