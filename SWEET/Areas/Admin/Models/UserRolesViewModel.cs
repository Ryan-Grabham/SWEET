using Microsoft.AspNetCore.Identity;
using SWEET.Models;

namespace SWEET.Areas.Admin.Models
{
    public class UserRolesViewModel
    {

        public UserModel? User { get; set; }
        public List<string>? Roles { get; set; }


    }
}
