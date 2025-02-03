using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDentalApp.Controllers
{
    public class LibroController : Controller
    {
        private static readonly List<dynamic> LibroRegistros = new List<dynamic>
        {
            new { Dia = "12PM", Paciente = "Enrique Estrada", Trabajo = "Prótesis Parcial", Costo = "$1,800", Abono = "$800", Entrega = "18/10/24" },
            new { Dia = "Jueves", Paciente = "Alejandro Chavez", Trabajo = "Puente de Zirconia", Costo = "$2,400", Abono = "$1,200", Entrega = "22/10/24" },
            new { Dia = "Viernes", Paciente = "Sofía Villaseñor", Trabajo = "Coronas", Costo = "$1,800", Abono = "$900", Entrega = "25/10/24" }
        };

        public IActionResult Index()
        {
            return View(LibroRegistros);
        }
    }
}
