using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class MarcaBD
    {
         public static int insertarMarca(string nombre)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_insertMarca");
             sqlcmd.Parameters.AddWithValue("@nomb", nombre);

             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static int actualizarMarca(int cod, string nombre)
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_updateMarca");
             sqlcmd.Parameters.AddWithValue("@cod", cod);
             sqlcmd.Parameters.AddWithValue("@nomb", nombre);
             return AccesoDatos.ejecutarIUD(sqlcmd);
         }
         public static DataTable listarMarca()
         {
             SqlCommand sqlcmd = AccesoDatos.consultaStore("sp_listarMarca");
             return AccesoDatos.datavirtual(sqlcmd);
         }
    }
}
