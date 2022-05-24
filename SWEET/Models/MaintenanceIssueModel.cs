using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SWEET.Models
{
    public class MaintenanceIssueModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        DateTime Created { get; set; }
        public DateTime Updated { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public IdentityUser LoggedBy { get; set; }
        public RoomModel Room { get; set; }
        public AssetModel Assets { get; set; }

    }
}
