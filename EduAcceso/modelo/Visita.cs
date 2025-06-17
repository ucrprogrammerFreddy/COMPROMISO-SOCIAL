using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAcceso.Modelo
{
    public class Visita
    {
        public int idVisita { get; set; }
        public int idVisitante { get; set; }
        public int idUsuario { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string destino { get; set; }
        public string asunto { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaSalida { get; set; }
    }
}
