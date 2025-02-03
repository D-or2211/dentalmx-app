namespace LaboratorioDentalApp.Models
{
    public class Material
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int CantidadDisponible { get; set; }
        public string Unidad { get; set; } // Ej: kg, g, ml
        public DateTime FechaActualizacion { get; set; }
        public int NivelCritico { get; set; }
    }
}
