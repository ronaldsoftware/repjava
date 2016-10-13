using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class ProveedorBD
    {
        public static int insertarPproveedor(string nombre, string ruc,string dir,string corr,string tel, string cel)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_inserProveedor");
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            sqlcmd.Parameters.AddWithValue("@ruc", ruc);
            sqlcmd.Parameters.AddWithValue("@dir", dir);
            sqlcmd.Parameters.AddWithValue("@corr", corr);
            sqlcmd.Parameters.AddWithValue("@telef", tel);
            sqlcmd.Parameters.AddWithValue("@cel", cel);
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static int actualizarProveedor(int cod, string nombre)
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_updateMarca");
            sqlcmd.Parameters.AddWithValue("@cod", cod);
            sqlcmd.Parameters.AddWithValue("@nomb", nombre);
            return AccesoDatos.ejecutarIUD(sqlcmd);
        }
        public static DataTable listarProveedor()
        {
            SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarProveedor");
            return AccesoDatos.datavirtual(sqlcmd);
        }
    }
}
