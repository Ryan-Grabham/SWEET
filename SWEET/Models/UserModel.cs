using Microsoft.AspNetCore.Identity;

namespace SWEET.Models
{
    public class UserModel : IdentityUser
    {
        public string Firstname { get; set;}
        public string Surname { get; set; }
    }
}
