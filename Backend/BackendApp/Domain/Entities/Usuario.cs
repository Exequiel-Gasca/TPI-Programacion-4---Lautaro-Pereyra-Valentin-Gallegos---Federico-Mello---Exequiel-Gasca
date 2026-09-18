using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Usuario
    {
        private int IdUsuario { get; set; }
        private string Nombre { get; set; } = string.Empty;
        private string Apellido { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        private bool Estado { get; set; }
    }
}
