using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PermisoBD
    {
        public static DataTable listarPermiso()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarPermiso");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarPermiso(string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("insertPermiso");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);


            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
    }
}
