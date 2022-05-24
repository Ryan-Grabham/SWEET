using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SWEET.Data;

namespace SWEET.Controllers
{
    [Authorize]
    public class InstitutionController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _user;

        public InstitutionController(ApplicationDbContext db, UserManager<IdentityUser> user)
        {
            _db = db;
            _user = user;
        }

        public async Task<IActionResult> Index()
        {
            var institutions = _db.Institutions.ToList();
            return View(institutions);
        }
        
    }
}
