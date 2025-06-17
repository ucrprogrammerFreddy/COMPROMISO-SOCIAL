using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAcceso.Modelo
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }

    }
}
