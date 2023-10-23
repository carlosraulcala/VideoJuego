﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoJuegos.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public bool Genero { get; set; }
        public int Edad { get; set; }


    }
}
