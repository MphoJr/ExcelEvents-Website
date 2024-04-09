using Microsoft.AspNetCore.Mvc;

namespace TRAIL.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
