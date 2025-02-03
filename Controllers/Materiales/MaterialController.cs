using Microsoft.AspNetCore.Mvc;
using LaboratorioDentalApp.Models; // Importar el namespace donde está la clase Material
using System.Collections.Generic;
using System;

namespace LaboratorioDentalApp.Controllers
{
    public class MaterialController : Controller
    {
        // Lista estática de materiales de ejemplo
        private static readonly List<Material> Materiales = new List<Material>
        {
            new Material { Nombre = "Zirconia", Categoria = "Cerámica", CantidadDisponible = 5, Unidad = "kg", FechaActualizacion = DateTime.Now.AddDays(-2), NivelCritico = 3 },
            new Material { Nombre = "Alambre de Titanio", Categoria = "Metales", CantidadDisponible = 15, Unidad = "m", FechaActualizacion = DateTime.Now.AddDays(-1), NivelCritico = 5 },
            new Material { Nombre = "Resina Dental", Categoria = "Resinas", CantidadDisponible = 2, Unidad = "kg", FechaActualizacion = DateTime.Now.AddDays(-3), NivelCritico = 4 }
        };

        // Acción para mostrar el listado de materiales
        public IActionResult Index()
        {
            return View(Materiales);  // Pasar la lista de materiales a la vista
        }
    }
}
