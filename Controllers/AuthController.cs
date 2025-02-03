using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDentalApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
