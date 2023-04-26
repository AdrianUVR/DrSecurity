using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CURP
    {

        private static readonly Dictionary<Estado, string> CodigosEstado = new Dictionary<Estado, string>
        {
            { Estado.Aguascalientes, "AS" },
            { Estado.Baja_California, "BC" },
            { Estado.Baja_California_Sur, "BS" },
            { Estado.Campeche, "CC" },
            { Estado.Chiapas, "CS" },
            { Estado.Chihuahua, "CH" },
            { Estado.Coahuila, "CL" },
            { Estado.Colima, "CM" },
            { Estado.Distrito_Federal, "DF" },
            { Estado.Durango, "DG" },
            { Estado.Guanajuato, "GT" },
            { Estado.Guerrero, "GR" },
            { Estado.Hidalgo, "HG" },
            { Estado.Jalisco, "JC" },
            { Estado.Mexico, "MC" },
            { Estado.Morelos, "MS" },
            { Estado.Michoacan, "MN" },
            { Estado.Nayarit, "NT" },
            { Estado.Nuevo_Leon, "NL" },
            { Estado.Oaxaca, "OC" },
            { Estado.Puebla, "PL" },
            { Estado.Queretaro, "QT" },
            { Estado.Quintana_Roo, "QR" },
            { Estado.San_Luis_Potosi, "SP" },
            { Estado.Sinaloa, "SL" },
            { Estado.Sonora, "SR" },
            { Estado.Tabasco, "TC" },
            { Estado.Tamaulipas, "TS" },
            { Estado.Tlaxcala, "TL" },
            { Estado.Veracruz, "VZ" },
            { Estado.Yucatan, "YN" },
            { Estado.Zacatecas, "ZS" },
            { Estado.Extranjero, "NE" }
        };
    }
}
