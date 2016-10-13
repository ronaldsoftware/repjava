using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public  class IngresoBD
    {
        public static DataTable listarIngreso()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarIngresos");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarIngreso(string serie, string des, int codprove)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertIngresos2");
            sqlcmd.Parameters.AddWithValue("@serie", serie);
            sqlcmd.Parameters.AddWithValue("@descripcion", des);
            sqlcmd.Parameters.AddWithValue("@codprove", codprove);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable listarProducto()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listarProductos");
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
