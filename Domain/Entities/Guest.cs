using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Guest
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string FullName { get; set; }  = string.Empty;

        public string Email { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Nationality { get; set; } = string.Empty;
        [MaxLength(200)]
        public string CountryFlag {  get; set; } = string.Empty;

        [MaxLength(50)]
        public string NationalId { get; set; } = string.Empty ;



    }
}
