namespace SWEET.Models
{
    public class MaintenanceIssueModel
    {
        public int Id { get; set; }
        DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Description { get; set; }
        public staff StaffMember { get; set; }
        public rooms Room { get; set; }
        public assets Assets { get; set; }

    }
}
