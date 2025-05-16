using Microsoft.AspNetCore.Mvc;

namespace erp_psicologia.Controllers
{
    public class RegisterPsychologistController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            return RedirectToAction("Index");
        }
    }
}
