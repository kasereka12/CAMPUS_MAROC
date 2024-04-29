using Microsoft.AspNetCore.Identity;

namespace PrpjetPFA.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Cin { get; set; }
        public string? Region { get; set; }
    }
}
