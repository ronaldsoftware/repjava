using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PrecioBD
    {
        public static DataTable listarPrecio()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarprecio");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarPrecio(int codprove, int codprod, decimal precio )
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertarPrecio");
            sqlcmd.Parameters.AddWithValue("@codprove", codprove);
            sqlcmd.Parameters.AddWithValue("@codprod", codprod);
            sqlcmd.Parameters.AddWithValue("@precio ", precio);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
    }
}
