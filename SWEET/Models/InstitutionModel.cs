using System.ComponentModel.DataAnnotations;

namespace SWEET.Models
{
    public class InstitutionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public RoomModel Room { get; set; }
        public MaintenanceIssueModel MaintenanceIssue { get; set; }
        public GeneralIssueModel GeneralIssue { get; set; }
    }
}
