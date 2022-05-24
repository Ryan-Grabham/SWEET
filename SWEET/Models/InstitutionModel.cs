using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWEET.Models
{
    public class InstitutionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [NotMapped]
        public List<RoomModel> Rooms { get; set; }
        
        [NotMapped]
        public List<MaintenanceIssueModel> MaintenanceIssues { get; set; }

        [NotMapped]
        public List<GeneralIssueModel> GeneralIssues { get; set; }
    }
}
