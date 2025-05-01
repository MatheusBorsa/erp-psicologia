using erp_psicologia_classes.Infra.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace erp_psicologia.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
