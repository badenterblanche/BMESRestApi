using Microsoft.AspNetCore.Identity;

namespace BMESRestApi.Models.Shared
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
