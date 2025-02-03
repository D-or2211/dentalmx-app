using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDentalApp.Controllers.Trabajos
{
    public class TrabajosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TrabajosPorTecnico(string tecnicoNombre)
        {
            ViewBag.TecnicoNombre = tecnicoNombre;
            return View("Index");
        }
    }
}
