using LaboratorioDentalApp.Models.Tecnicos;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioDentalApp.Controllers
{
    public class TecnicosController : Controller
    {
        private static readonly List<Tecnico> Tecnicos = new List<Tecnico>
        {
            new Tecnico { Nombre = "Juan Pérez", IngresoMensual = "$25,000 MXN", Calificacion = 5, TrabajosRealizados = 120, MaterialUsado = 75 },
            new Tecnico { Nombre = "María López", IngresoMensual = "$22,000 MXN", Calificacion = 4, TrabajosRealizados = 110, MaterialUsado = 60 },
            new Tecnico { Nombre = "Carlos Herrera", IngresoMensual = "$20,000 MXN", Calificacion = 3, TrabajosRealizados = 95, MaterialUsado = 50 }
        };

        public IActionResult Index()
        {
            return View(Tecnicos);
        }

        public IActionResult Detalles(string tecnicoNombre)
        {
            // Buscar al técnico por nombre
            var tecnico = Tecnicos.Find(t => t.Nombre == tecnicoNombre);

            if (tecnico == null)
            {
                return NotFound(); // Muestra error si no se encuentra el técnico
            }

            return View(tecnico);
        }
    }
}
