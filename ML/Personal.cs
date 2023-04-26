using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Personal
    {

        public int IdPersona { get; set; }


        public string Nombre { get; set; }


        public string ApellidoPaterno { get; set; }


        public string ApellidoMaterno  { get; set; }


        public DateTime FechaNacimiento { get; set; }

        public string sexo { get; set; }


        public string EstadoNacimiento { get; set; }


        public string Telefono { get; set; }

        public string DireccionActual { get; set; }

        public ML.Direccion Direccion { get; set; }

        public List<object> Personales { get; set; }
    }
}
