using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoJuegos.Models
{
    public class Email
    {
        [Key]
        public int idEmail { get; set; }
        public string email { get; set; }

    }
}
