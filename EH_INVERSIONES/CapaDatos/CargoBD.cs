using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CargoBD
    {
        public static DataTable listarCargo()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listarCargos");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarCargo(string nombre, int codar)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("insertCargo");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            sqlcmd.Parameters.AddWithValue("@codar", codar);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        
    }
}
