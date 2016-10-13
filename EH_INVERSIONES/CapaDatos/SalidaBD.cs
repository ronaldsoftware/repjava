using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
     public class SalidaBD
    {
        public static DataTable listarSalida()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarSalida");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static int insertarSalida(string serie, string des)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertSal");
            sqlcmd.Parameters.AddWithValue("@serie", serie);
            sqlcmd.Parameters.AddWithValue("@descripcion", des);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable listarProducto()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listarProductos");
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
