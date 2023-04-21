using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set;}
        public int Edad { get; set;}
        public string Correo { get; set;}
        public string Habilidad1 { get; set;}
        public string Habilidad2 { get; set; }
        public int IdTipo { get; set; }
        public string Accion { get; set;}
        public List<Persona> Personas { get; set;}

    }
}
