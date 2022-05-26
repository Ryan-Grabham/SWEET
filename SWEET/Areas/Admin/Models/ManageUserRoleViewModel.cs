using Microsoft.AspNetCore.Identity;
using SWEET.Models;

namespace SWEET.Areas.Admin.Models
{
    public class ManageUserRoleViewModel
    {
        public UserModel? User { get; set; }
        public IdentityRole? Role { get; set; }
        public bool IsInRole { get; set; }
    }
}
