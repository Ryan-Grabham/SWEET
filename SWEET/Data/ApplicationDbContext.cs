using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWEET.Models;

namespace SWEET.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<InstitutionModel> Institutions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}