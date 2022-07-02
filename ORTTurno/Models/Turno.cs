using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORTTurno.Models
{
    public class Turno
    {
        public int Idturno { get; set; }
        public int IdUsuario { get; set; }
        public string Especialidad { get; set; }
        public string Sede { get; set; }
        public DateTime Fecha { get; set; }
    }
}