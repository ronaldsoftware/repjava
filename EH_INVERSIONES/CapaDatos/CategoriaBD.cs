using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CategoriaBD
    {
        public static int insertarCategoria(string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertCategoria");
            sqlcmd.Parameters.AddWithValue("@des", nombre);

            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int actualizarCategoria(int cod, string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_actualizarCategoria");
            sqlcmd.Parameters.AddWithValue("@cod", cod);
            sqlcmd.Parameters.AddWithValue("@des", nombre);
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable listarCategoria()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarCategoria");
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
