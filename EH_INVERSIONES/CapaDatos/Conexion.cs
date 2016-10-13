using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Conexion
    {
        private static string conexionBD = "data source=localhost;initial catalog=BDVENTASEH08;integrated security=true;";

        public static string ConexionBD
        {
            get
            {
                return conexionBD;
            }

            set
            {
                conexionBD = value;
            }
        }
    }
}
