using Microsoft.AspNetCore.Http;


namespace Core.Cabins.Commands.Create.Dtos
{
    public class CreateCabinRequestDto
    {
        public string Name { get; set; } = string.Empty;

        public int MaxCapacity { get; set; }

        public decimal RegularPrice { get; set; }

        public int Discount { get; set; }

        public string Description { get; set; } = string.Empty;

        public IFormFile Image { get; set; } = default!;
    }
}
