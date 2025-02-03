using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDentalApp.Controllers
{
    public class ClinicaController : Controller
    {
        public IActionResult DashboardClinica()
        {
            return View();
        }

        // Vista de Doctoras
        public IActionResult Doctoras()
        {
            return View();
        }

        // Vista de Trabajos
        public IActionResult Trabajos()
        {
            return View();
        }

        // Vista de Nóminas
        public IActionResult Nominas()
        {
            return View();
        }

        // Vista de Pedidos
        public IActionResult Pedidos()
        {
            return View();
        }

        public IActionResult Pacientes()
        {
            return View();
        }
    }
}
