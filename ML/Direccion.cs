using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Direccion
    {


        public int IdDireccion { get; set; }

        public string EstadoOCiudad { get; set; }


        public string DelegacionOMunicipio { get; set; }


        public string Colonia { get; set; }


        public int  Numero { get; set; }


        public List<object> Direcciones { get; set; }
    }
}
