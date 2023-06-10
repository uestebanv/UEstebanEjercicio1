using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace BL
{
    public class Conexion
    {
        public static string Cadena()
        {
            return ConfigurationManager.ConnectionStrings["UEstebanEjercicio1"].ConnectionString.ToString();
        }
    }
}
