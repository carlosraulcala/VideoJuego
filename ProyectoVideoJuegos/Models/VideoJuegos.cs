using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoJuegos.Models
{
    public class VideoJuegos
    {
        [Key]
        public int idVideoJuego { get; set; }
        public string Nombre { get; set; }
        public string TipoDePago { get; set; }
        public bool EsGrupal { get; set; }
        public string Tipo { get; set; }

    }
}
