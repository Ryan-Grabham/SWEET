using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWEET.Models;

namespace SWEET.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<InstitutionModel> Institutions { get; set; }
        public DbSet<RoomModel> RoomModel { get; set; }
        public DbSet<AssetModel> AssetModel { get; set; }
        public DbSet<GeneralIssueModel> GeneralIssueModel { get; set; }
        public DbSet<MaintenanceIssueModel> MaintenanceIssueModel { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        
    }
}