using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAcceso.Modelo
{
    public class Visitante
    {
        public int idVisitante {  get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public int direccion {  get; set; }
    }
}
