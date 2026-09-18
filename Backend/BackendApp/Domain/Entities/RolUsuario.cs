using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RolUsuario
    {
        private int IdRol { get; set; }
        private string Nombre { get; set; } = string.Empty;
        private string Descripcion { get; set; } = string.Empty;
    }
}
