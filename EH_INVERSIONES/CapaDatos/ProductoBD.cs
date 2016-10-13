using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProductoBD
    {
        public static int insertarProducto(string nombre, decimal pre, int stock, int codm, int codc)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_insertProducto");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            sqlcmd.Parameters.AddWithValue("@precio", pre);
            sqlcmd.Parameters.AddWithValue("@stock", stock);
            sqlcmd.Parameters.AddWithValue("@codmarca", codm);
            sqlcmd.Parameters.AddWithValue("@codcat", codc);
            
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int actualizarProducto(int cod, string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_updateMarca");
            sqlcmd.Parameters.AddWithValue("@cod", cod);
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable listarProducto()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listarProductos");
            return AccesoDatos.datavirtual(sqlcmd);
        }
        public static DataTable FiltrarProducto(string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("usp_listarProductos_filtro");
            sqlcmd.Parameters.AddWithValue("@nombre", nombre);
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
