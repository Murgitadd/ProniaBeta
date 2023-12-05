using Microsoft.AspNetCore.Identity;

namespace ProniaBeta.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
