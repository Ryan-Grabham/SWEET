using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public UserModel LoggedBy { get; set; }

        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public RoomModel Room { get; set; }

        public int AssetId { get; set; }

        [ForeignKey("AssetId")]

        public AssetModel Asset { get; set; }

    }
}
