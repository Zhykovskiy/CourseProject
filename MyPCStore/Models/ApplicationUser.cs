using Microsoft.AspNetCore.Identity;

namespace MyPCStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
