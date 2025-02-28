using Microsoft.AspNetCore.Identity;

namespace MexicanRestaurants.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set;}
    }
}
