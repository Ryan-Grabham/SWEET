using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWEET.Models
{
    public class GeneralIssueModel
    {
        public int Id { get; set; } 
        DateTime Created { get; set; }
        public DateTime Updated { get; set; }  
        public string Description { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser LoggedBy { get; set; }



    }
}
